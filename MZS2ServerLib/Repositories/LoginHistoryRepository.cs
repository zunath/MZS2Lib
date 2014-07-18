using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MZS2ServerLib
{
    public static class LoginHistoryRepository
    {
        public static string AddLoginHistory(int playerID, string ipAddress)
        {
            LoginHistory history = new LoginHistory
            {
                IPAddress = ipAddress,
                PlayerCharacterID = playerID,
                Timestamp = DateTime.Now
            };

            using (MZS2Context context = new MZS2Context())
            {
                context.LoginHistories.Add(history);
                context.SaveChanges();
            }

            return "TRUE";
        }

        public static string GetLoginHistory(int playerID)
        {
            string result = string.Empty;

            using (MZS2Context context = new MZS2Context())
            {
                LoginHistory history = context.LoginHistories.SingleOrDefault(x => x.PlayerCharacterID == playerID);

                if (history != null)
                {
                    result = string.Join(";",
                        history.LoginHistoryID,
                        history.IPAddress,
                        history.PlayerCharacterID,
                        history.Timestamp);
                }
            }

            return result;
        }
    }
}
