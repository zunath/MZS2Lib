using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MZS2ServerLib
{
    public static class KeyItemRepository
    {
        public static string SavePlayerKeyItem(string sPCID, string sKeyItemID)
        {
            string result = "FAILED";

            try
            {
                int iPCID = Convert.ToInt32(sPCID);
                int iKeyItemID = Convert.ToInt32(sKeyItemID);


                using (MZS2Context context = new MZS2Context(ConfigurationManager.ConnectionString))
                {
                    player_key_items dbItem = context.player_key_items.SingleOrDefault(x => x.KeyItemID == iKeyItemID && x.PlayerCharacterID == iPCID);

                    if (dbItem == null)
                    {
                        player_key_items keyItem = new player_key_items
                        {
                            KeyItemID = iKeyItemID,
                            PlayerCharacterID = iPCID
                        };

                        context.player_key_items.Add(keyItem);
                    }
                    else
                    {
                        result = "EXISTS";
                    }
                    key_item_domain keyItemEntry = context.key_item_domain.SingleOrDefault(x => x.KeyItemID == iKeyItemID);

                    context.SaveChanges();
                    result = "SUCCESS;" + keyItemEntry.Name;
                }
            }
            catch
            {
                result = "FAILED";
            }

            return result;
        }

        public static string DeletePlayerKeyItem(string sPCID, string sKeyItemID)
        {
            string result = "FAILURE";
            try
            {
                int iPCID = Convert.ToInt32(sPCID);
                int iKeyItemID = Convert.ToInt32(sKeyItemID);

                using (MZS2Context context = new MZS2Context(ConfigurationManager.ConnectionString))
                {
                    player_key_items keyItem = context.player_key_items.SingleOrDefault(x => x.PlayerCharacterID == iPCID && x.KeyItemID == iKeyItemID);

                    if (keyItem != null)
                    {
                        context.player_key_items.Remove(keyItem);
                        context.SaveChanges();
                        result = "TRUE;" + keyItem.key_item_domain.Name;
                    }
                    else
                    {
                        result = "FALSE";
                    }
                }
            }
            catch
            {
                result = "FAILURE";
            }

            return result;
        }

        public static string DoesPlayerHaveKeyItem(string sPCID, string sKeyItemID)
        {
            string result = "FAILURE";

            try
            {
                int iPCID = Convert.ToInt32(sPCID);
                int iKeyItemID = Convert.ToInt32(sKeyItemID);

                using (MZS2Context context = new MZS2Context(ConfigurationManager.ConnectionString))
                {
                    player_key_items keyItem = context.player_key_items.SingleOrDefault(x => x.PlayerCharacterID == iPCID && x.KeyItemID == iKeyItemID);

                    if (keyItem == null)
                    {
                        result = "FALSE";
                    }
                    else
                    {
                        result = "TRUE";
                    }
                }
            }
            catch
            {
                result = "FAILURE";
            }

            return result;
        }

    }


}
