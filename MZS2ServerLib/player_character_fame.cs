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
    
    public partial class player_character_fame
    {
        public int PlayerCharacterFameID { get; set; }
        public int PlayerCharacterID { get; set; }
        public int FameRegionID { get; set; }
        public int Amount { get; set; }
    
        public virtual fame_region_domain fame_region_domain { get; set; }
        public virtual playercharacter playercharacter { get; set; }
    }
}
