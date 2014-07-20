using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MZS2ServerLib
{
    public static class AuthorizedDMRepository
    {
        public static string IsCDKeyAuthorized(string cdKey)
        {
            string result = "FALSE";

            using (MZS2Context context = new MZS2Context(ConfigurationManager.ConnectionString))
            {
                authorized_dm dm = context.authorized_dm.SingleOrDefault(x => x.CDKey == cdKey);

                if (dm != null)
                {
                    result = "TRUE";
                }
            }

            return result;
        }

        public static string IsCDKeyAdmin(string cdKey)
        {
            string result = "FALSE";

            using (MZS2Context context = new MZS2Context(ConfigurationManager.ConnectionString))
            {
                authorized_dm dm = context.authorized_dm.SingleOrDefault(x => x.CDKey == cdKey);

                if (dm != null)
                {
                    if (dm.DMRole == 2)
                    {
                        result = "TRUE";
                    }
                }

            }

            return result;
        }

        public static string IsCDKeyDM(string cdKey)
        {
            string result = "FALSE";

            using (MZS2Context context = new MZS2Context(ConfigurationManager.ConnectionString))
            {
                authorized_dm dm = context.authorized_dm.SingleOrDefault(x => x.CDKey == cdKey);

                if (dm != null)
                {
                    if (dm.DMRole == 1)
                    {
                        result = "TRUE";
                    }
                }

            }
            return result;
        }
    }
}
