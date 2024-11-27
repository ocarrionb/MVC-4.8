using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Test.Models.BD
{
    public partial class Sale
    {
        public Sale()
        {
            Concept = new HashSet<Concept>();
        }

        public int SaleId { get; set; }
        public DateTime Date { get; set; }
        public int CustomerId { get; set; }
        public decimal Total { get; set; }
        public bool Active { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual ICollection<Concept> Concept { get; set; }
    }
}
