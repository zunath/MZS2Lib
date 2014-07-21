//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MZS2ServerLib
{
    using System;
    using System.Collections.Generic;
    
    public partial class quest
    {
        public quest()
        {
            this.quests1 = new HashSet<quest>();
            this.quests11 = new HashSet<quest>();
            this.quests12 = new HashSet<quest>();
            this.quests13 = new HashSet<quest>();
            this.quests14 = new HashSet<quest>();
        }
    
        public int QuestID { get; set; }
        public string Name { get; set; }
        public string JournalTag { get; set; }
        public int QuestTypeID { get; set; }
        public int FameRegionID { get; set; }
        public int FameRequired { get; set; }
        public int MaxLevel { get; set; }
        public int MinLevel { get; set; }
        public bool AllowRewardSelection { get; set; }
        public int FinishState { get; set; }
        public bool IsRepeatable { get; set; }
        public string MapNoteTag { get; set; }
        public Nullable<int> QuestAcceptedKeyItemID { get; set; }
        public bool RemoveTemporaryKeyItem { get; set; }
        public int GoldReward { get; set; }
        public int XPReward { get; set; }
        public int KeyItemIDReward { get; set; }
        public int FameReward { get; set; }
        public string ItemRewardResref1 { get; set; }
        public int ItemRewardQuantity1 { get; set; }
        public string ItemRewardResref2 { get; set; }
        public int ItemRewardQuantity2 { get; set; }
        public string ItemRewardResref3 { get; set; }
        public int ItemRewardQuantity3 { get; set; }
        public string ItemRewardResref4 { get; set; }
        public int ItemRewardQuantity4 { get; set; }
        public string ItemRewardResref5 { get; set; }
        public int ItemRewardQuantity5 { get; set; }
        public int KillGroupID1 { get; set; }
        public int KillGroupQuantity1 { get; set; }
        public int KillGroupID2 { get; set; }
        public int KillGroupQuantity2 { get; set; }
        public int KillGroupID3 { get; set; }
        public int KillGroupQuantity3 { get; set; }
        public int KillGroupID4 { get; set; }
        public int KillGroupQuantity4 { get; set; }
        public int KillGroupID5 { get; set; }
        public int KillGroupQuantity5 { get; set; }
        public string RequiredItem1 { get; set; }
        public int RequiredItemQuantity1 { get; set; }
        public string RequiredItem2 { get; set; }
        public int RequiredItemQuantity2 { get; set; }
        public string RequiredItem3 { get; set; }
        public int RequiredItemQuantity3 { get; set; }
        public string RequiredItem4 { get; set; }
        public int RequiredItemQuantity4 { get; set; }
        public string RequiredItem5 { get; set; }
        public int RequiredItemQuantity5 { get; set; }
        public int RequiredKeyItem1 { get; set; }
        public int RequiredKeyItem2 { get; set; }
        public int RequiredKeyItem3 { get; set; }
        public int RequiredKeyItem4 { get; set; }
        public int RequiredKeyItem5 { get; set; }
        public int PrerequisiteQuestID1 { get; set; }
        public int PrerequisiteQuestID2 { get; set; }
        public int PrerequisiteQuestID3 { get; set; }
        public int PrerequisiteQuestID4 { get; set; }
        public int PrerequisiteQuestID5 { get; set; }
    
        public virtual fame_region_domain fame_region_domain { get; set; }
        public virtual key_item_domain QuestAcceptedKeyItem { get; set; }
        public virtual key_item_domain KeyItemReward { get; set; }
        public virtual key_item_domain RequiredKeyItem_Nav1 { get; set; }
        public virtual key_item_domain RequiredKeyItem_Nav2 { get; set; }
        public virtual key_item_domain RequiredKeyItem_Nav3 { get; set; }
        public virtual key_item_domain RequiredKeyItem_Nav4 { get; set; }
        public virtual key_item_domain RequiredKeyItem_Nav5 { get; set; }
        public virtual quest_kill_groups KillGroup2 { get; set; }
        public virtual quest_kill_groups KillGroup3 { get; set; }
        public virtual quest_kill_groups KillGroup4 { get; set; }
        public virtual quest_kill_groups KillGroup5 { get; set; }
        public virtual quest_kill_groups KillGroup1 { get; set; }
        public virtual ICollection<quest> quests1 { get; set; }
        public virtual quest quest1 { get; set; }
        public virtual ICollection<quest> quests11 { get; set; }
        public virtual quest quest2 { get; set; }
        public virtual ICollection<quest> quests12 { get; set; }
        public virtual quest quest3 { get; set; }
        public virtual ICollection<quest> quests13 { get; set; }
        public virtual quest quest4 { get; set; }
        public virtual ICollection<quest> quests14 { get; set; }
        public virtual quest quest5 { get; set; }
    }
}