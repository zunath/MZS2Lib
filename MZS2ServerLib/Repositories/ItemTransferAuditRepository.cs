using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MZS2ServerLib
{
    public static class ItemTransferAuditRepository
    {
        public static string SaveItemTransferAudit(
            string itemName,
            string itemTag,
            string itemResref,
            string quantity,
            string oldPCID,
            string newPCID,
            string oldDMCDKey,
            string newDMCDKey,
            string areaName,
            string areaTag,
            string areaResref,
            string eventType)
        {
            string result = "FALSE";
            // One of the identifiers must be valid for us to even care about storing it.
            if (oldPCID == "~" && newPCID == "~" &&
                oldDMCDKey == "~" && newDMCDKey == "~")
            {
                return result;
            }

            using (MZS2Context context = new MZS2Context(ConfigurationManager.ConnectionString))
            {
                Nullable<int> dbOldDMID = new Nullable<int>();
                Nullable<int> dbNewDMID = new Nullable<int>();
                int eventTypeID = Convert.ToInt32(eventType);

                if (oldDMCDKey != "~")
                {
                    authorized_dm dm = context.authorized_dm.SingleOrDefault(x => x.CDKey == oldDMCDKey);

                    if (dm != null)
                    {
                        dbOldDMID = dm.AuthorizedDMID;
                    }
                }

                if (newDMCDKey != "~")
                {
                    authorized_dm dm = context.authorized_dm.SingleOrDefault(x => x.CDKey == newDMCDKey);

                    if (dm != null)
                    {
                        dbNewDMID = dm.AuthorizedDMID;
                    }
                }


                Nullable<int> dbOldPCID = oldPCID == "~" ? new Nullable<int>() : Convert.ToInt32(oldPCID);
                Nullable<int> dbNewPCID = newPCID == "~" ? new Nullable<int>() : Convert.ToInt32(newPCID);
                int dbQuantity = Convert.ToInt32(quantity);

                item_transfer_audit audit = new item_transfer_audit
                {
                    AreaName = areaName,
                    AreaResref = areaResref,
                    AreaTag = areaTag,
                    OldAuthorizedDMID = dbOldDMID,
                    OldPlayerCharacterID = dbOldPCID,
                    NewAuthorizedDMID = dbNewDMID,
                    NewPlayerCharacterID = dbNewPCID,
                    ItemName = itemName,
                    ItemResref = itemResref,
                    ItemTag = itemTag,
                    Quantity = dbQuantity,
                    ModuleEventTypeID = eventTypeID
                };

                context.item_transfer_audit.Add(audit);
                context.SaveChanges();
                result = "TRUE";
            }

            return result;
        }
    }
}
