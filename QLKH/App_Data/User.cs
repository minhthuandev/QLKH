//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLKH.App_Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public System.Guid ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public System.Guid RoleID { get; set; }
        public bool IsDelete { get; set; }
    
        public virtual Role Role { get; set; }
    }
}