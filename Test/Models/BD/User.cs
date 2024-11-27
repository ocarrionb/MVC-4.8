using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Test.Models.BD
{
    public partial class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
