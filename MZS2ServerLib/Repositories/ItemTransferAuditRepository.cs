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
            string pcID,
            string dmCDKey,
            string areaName,
            string areaTag,
            string areaResref)
        {
            string result = "FALSE";

            using (MZS2Context context = new MZS2Context(ConfigurationManager.ConnectionString))
            {
                Nullable<int> dbDMID = new Nullable<int>();

                if (dmCDKey != "~")
                {
                    authorized_dm dm = context.authorized_dm.SingleOrDefault(x => x.CDKey == dmCDKey);

                    if (dm != null)
                    {
                        dbDMID = dm.AuthorizedDMID;
                    }
                }


                Nullable<int> dbPCID = pcID == "~" ? new Nullable<int>() : Convert.ToInt32(pcID);
                int dbQuantity = Convert.ToInt32(quantity);

                item_transfer_audit audit = new item_transfer_audit
                {
                    AreaName = areaName,
                    AreaResref = areaResref,
                    AreaTag = areaTag,
                    AuthorizedDMID = dbDMID,
                    ItemName = itemName,
                    ItemResref = itemResref,
                    ItemTag = itemTag,
                    PlayerCharacterID = dbPCID,
                    Quantity = dbQuantity
                };

                context.item_transfer_audit.Add(audit);
                context.SaveChanges();
                result = "TRUE";
            }

            return result;
        }
    }
}
