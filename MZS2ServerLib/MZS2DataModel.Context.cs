﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MZS2Context : DbContext
    {
        public MZS2Context()
            : base("name=MZS2Context")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<dm_log> dm_log { get; set; }
        public DbSet<pc_corpse> pc_corpse { get; set; }
        public DbSet<player_info> player_info { get; set; }
        public DbSet<pwdata> pwdatas { get; set; }
        public DbSet<pwobjdata> pwobjdatas { get; set; }
        public DbSet<zst_storage> zst_storage { get; set; }
        public DbSet<zsttemplate> zsttemplates { get; set; }
        public DbSet<playercharacter> playercharacters { get; set; }
        public DbSet<errorlog> errorlogs { get; set; }
        public DbSet<authorized_dm> authorized_dm { get; set; }
        public DbSet<dm_role_domain> dm_role_domain { get; set; }
        public DbSet<loginhistory> loginhistories { get; set; }
        public DbSet<item_transfer_audit> item_transfer_audit { get; set; }
        public DbSet<module_event_type_domain> module_event_type_domain { get; set; }
        public DbSet<fame_region_domain> fame_region_domain { get; set; }
        public DbSet<key_item_category_domain> key_item_category_domain { get; set; }
        public DbSet<key_item_domain> key_item_domain { get; set; }
        public DbSet<quest_kill_groups> quest_kill_groups { get; set; }
        public DbSet<quest_type_domain> quest_type_domain { get; set; }
        public DbSet<quest> quests { get; set; }
        public DbSet<player_key_items> player_key_items { get; set; }
        public DbSet<player_character_fame> player_character_fame { get; set; }
    }
}
