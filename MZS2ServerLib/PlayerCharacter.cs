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
    
    public partial class playercharacter
    {
        public playercharacter()
        {
            this.loginhistories = new HashSet<loginhistory>();
        }
    
        public int PlayerCharacterID { get; set; }
        public string AccountName { get; set; }
        public string CDKey { get; set; }
        public string CharacterName { get; set; }
        public int HitPoints { get; set; }
        public string LocationAreaTag { get; set; }
        public double LocationX { get; set; }
        public double LocationY { get; set; }
        public double LocationZ { get; set; }
        public double LocationOrientation { get; set; }
        public System.DateTime CreateTimestamp { get; set; }
    
        public virtual ICollection<loginhistory> loginhistories { get; set; }
    }
}
