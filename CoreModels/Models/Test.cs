using System;
using System.Collections.Generic;

#nullable disable

namespace CoreModels.Models
{
    public partial class Test
    {
        public long Id { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Cnic { get; set; }
        public string Gender { get; set; }
        public DateTime Dob { get; set; }
        public string Uaddress { get; set; }
        public string Phone { get; set; }
        public string Education { get; set; }
    }
}
