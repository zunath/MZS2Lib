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
    
    public partial class authorized_dm
    {
        public int AuthorizedDMID { get; set; }
        public string Name { get; set; }
        public string CDKey { get; set; }
        public int DMRole { get; set; }
    
        public virtual dm_role_domain dm_role_domain { get; set; }
    }
}
