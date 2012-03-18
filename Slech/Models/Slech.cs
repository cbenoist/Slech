using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Slech.Models
{
    public class Slech
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public DateTime SubmitDate { get; set; }

        public virtual Slecher Slecher { get; set; }
    }
}