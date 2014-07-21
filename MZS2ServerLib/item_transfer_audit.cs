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
    
    public partial class item_transfer_audit
    {
        public int ItemTransferAuditID { get; set; }
        public string ItemName { get; set; }
        public string ItemTag { get; set; }
        public string ItemResref { get; set; }
        public int Quantity { get; set; }
        public Nullable<int> OldPlayerCharacterID { get; set; }
        public Nullable<int> NewPlayerCharacterID { get; set; }
        public Nullable<int> OldAuthorizedDMID { get; set; }
        public Nullable<int> NewAuthorizedDMID { get; set; }
        public string AreaName { get; set; }
        public string AreaTag { get; set; }
        public string AreaResref { get; set; }
        public System.DateTime TransferTimestamp { get; set; }
        public int ModuleEventTypeID { get; set; }
    
        public virtual authorized_dm authorized_dm { get; set; }
        public virtual authorized_dm authorized_dm1 { get; set; }
        public virtual playercharacter playercharacter { get; set; }
        public virtual playercharacter playercharacter1 { get; set; }
    }
}