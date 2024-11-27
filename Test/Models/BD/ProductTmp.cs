using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Test.Models.BD
{
    public partial class ProductTmp
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string UnitPrice { get; set; }
        public decimal Cost { get; set; }
        public decimal Count { get; set; }
    }
}
