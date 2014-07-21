using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MZS2ServerLib
{
    public static class QuestRepository
    {
        public static string GetQuestDetailsByID(string sQuestID)
        {
            string result = string.Empty;

            try
            {
                int iQuestID = Convert.ToInt32(sQuestID);
                using (MZS2Context context = new MZS2Context(ConfigurationManager.ConnectionString))
                {
                    quest dbQuest = context.quests.SingleOrDefault(x => x.QuestID == iQuestID);

                    if (dbQuest != null)
                    {
                        result = string.Join(";",
                            dbQuest.QuestID,
                            dbQuest.Name,
                            dbQuest.JournalTag,
                            dbQuest.QuestTypeID,
                            dbQuest.FameRegionID,
                            dbQuest.FameRequired,
                            dbQuest.MaxLevel,
                            dbQuest.MinLevel,
                            dbQuest.AllowRewardSelection,
                            dbQuest.FinishState,
                            dbQuest.IsRepeatable,
                            dbQuest.MapNoteTag,
                            dbQuest.QuestAcceptedKeyItemID,
                            dbQuest.RemoveTemporaryKeyItem);
                    }
                }
            }
            catch
            {
                result = string.Empty;
            }

            return result;
        }
    }
}
