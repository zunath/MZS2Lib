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

            using (MZS2Context context = new MZS2Context(ConfigurationManager.ConnectionString))
            {
                context.LoginHistories.Add(history);
                context.SaveChanges();
            }

            return "TRUE";
        }

        public static string GetLoginHistoryByID(string sLoginHistoryID)
        {
            int iLoginHistoryID = Convert.ToInt32(sLoginHistoryID);
            string result = string.Empty;

            System.IO.File.WriteAllText("C:\\getloginhistorytest.txt", "iLoginHistoryID = " + iLoginHistoryID); // DEBUG

            using (MZS2Context context = new MZS2Context(ConfigurationManager.ConnectionString))
            {
                LoginHistory history = context.LoginHistories.SingleOrDefault(x => x.LoginHistoryID == iLoginHistoryID);

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
