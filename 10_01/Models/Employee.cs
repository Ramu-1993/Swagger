//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _10_01.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string location { get; set; }
        public Nullable<int> DepartmentID { get; set; }
        public Nullable<System.DateTime> HireDate { get; set; }
    
        public virtual Department Department { get; set; }
    }
}
