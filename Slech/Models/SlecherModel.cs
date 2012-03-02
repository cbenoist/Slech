﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Slech.Models
{
    public class SlecherModel
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual ICollection<SlechModel> Sleches { get; set; }
    }
}