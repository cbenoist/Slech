using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Slech.Models
{
    public class SlechModel
    {
        public int Id { get; set; }
        public string Slech { get; set; }
        public DateTime SubmitDate { get; set; }

        public virtual SlecherModel Slecher { get; set; }
    }
}