//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PeterWeb.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Inkopslista
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Kategori { get; set; }
        public string Butik { get; set; }
        public Nullable<int> Antal { get; set; }
        public string Beskrivning { get; set; }
        public Nullable<int> inkopt { get; set; }
        public Nullable<System.DateTime> Create { get; set; }
        public Nullable<System.DateTime> Modified { get; set; }
    }
}
