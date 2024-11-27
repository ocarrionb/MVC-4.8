using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Test.Models.BD
{
    public partial class Members
    {
        public int MemberId { get; set; }
        public string MemberName { get; set; }
        public string MemberLastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int? MemberType { get; set; }
        public bool? IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
