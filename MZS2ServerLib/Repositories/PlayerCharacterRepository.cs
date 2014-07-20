using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MZS2ServerLib
{
    public static class PlayerCharacterRepository
    {
        public static string GetPlayerCharacterByID(string sPCID)
        {
            int iPCID = Convert.ToInt32(sPCID);
            string result = string.Empty;

            using (MZS2Context context = new MZS2Context(ConfigurationManager.ConnectionString))
            {
                playercharacter pc = context.playercharacters.SingleOrDefault(x => x.PlayerCharacterID == iPCID);

                if (pc != null)
                {
                    result = string.Join(";",
                        pc.PlayerCharacterID,
                        pc.AccountName,
                        pc.CDKey,
                        pc.CharacterName,
                        pc.HitPoints,
                        pc.LocationAreaTag,
                        pc.LocationOrientation,
                        pc.LocationX,
                        pc.LocationY,
                        pc.LocationZ);
                }
            }


            return result;
        }

        public static string SavePlayerCharacter(
            string sPCID, 
            string accountName,
            string cdKey,
            string characterName,
            string sHitPoints,
            string locationAreaTag,
            string sLocationX,
            string sLocationY,
            string sLocationZ,
            string sLocationOrientation)
        {
            string result = string.Empty;
            int pcID = Convert.ToInt32(sPCID);
            int hp = Convert.ToInt32(sHitPoints);
            double orientation = Convert.ToDouble(sLocationOrientation);
            double locationX = Convert.ToDouble(sLocationX);
            double locationY = Convert.ToDouble(sLocationY);
            double locationZ = Convert.ToDouble(sLocationZ);

            if (pcID > 0)
            {
                using (MZS2Context context = new MZS2Context(ConfigurationManager.ConnectionString))
                {
                    playercharacter existing = context.playercharacters.SingleOrDefault(x => x.PlayerCharacterID == pcID);

                    if (existing == null)
                    {
                        playercharacter pc = new playercharacter
                        {
                            AccountName = accountName,
                            CDKey = cdKey,
                            CharacterName = characterName,
                            HitPoints = hp,
                            LocationAreaTag = locationAreaTag,
                            LocationOrientation = orientation,
                            LocationX = locationX,
                            LocationY = locationY,
                            LocationZ = locationZ,
                            PlayerCharacterID = pcID
                        };

                        context.playercharacters.Add(pc);
                    }
                    else
                    {
                        existing.AccountName = accountName;
                        existing.CDKey = cdKey;
                        existing.CharacterName = characterName;
                        existing.HitPoints = hp;
                        existing.LocationAreaTag = locationAreaTag;
                        existing.LocationOrientation = orientation;
                        existing.LocationX = locationX;
                        existing.LocationY = locationY;
                        existing.LocationZ = locationZ;
                    }

                    context.SaveChanges();
                }
            }

            return result;
        }
    }
}
