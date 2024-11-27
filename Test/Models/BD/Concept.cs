using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Test.Models.BD
{
    public partial class Concept
    {
        public int ConceptId { get; set; }
        public decimal Quantity { get; set; }
        public int ProductId { get; set; }
        public int SaleId { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Amount { get; set; }

        public virtual Product Product { get; set; }
        public virtual Sale Sale { get; set; }
    }
}
