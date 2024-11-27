﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Test.Models.BD
{
    public partial class Sales
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Direction { get; set; }
        public int? Type { get; set; }
        public int? Amount { get; set; }
    }
}
