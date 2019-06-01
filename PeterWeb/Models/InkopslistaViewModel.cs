using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PeterWeb.Models
{
    public class InkopslistaViewModel
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