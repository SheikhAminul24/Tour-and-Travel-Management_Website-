//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cicerone_2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class db_admin
    {
        public db_admin()
        {
            this.packages = new HashSet<package>();
        }
    
        public int admin_id { get; set; }
        public string admin_username { get; set; }
        public string admin_password { get; set; }
    
        public virtual ICollection<package> packages { get; set; }
    }
}
