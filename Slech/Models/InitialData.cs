using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Slech.Models
{
    public class InitialData : DictionarySlechRepository 
    {
        public InitialData()
        {
            Add(new Slech
            {
                Id = 1,
                Text = "This is a test of the slech broadcasting system",
                Slecher = null,
                SubmitDate = DateTime.Now
            });
            Add(new Slech
            {
                Id = 2,
                Text = "System is rocking!!",
                Slecher = null,
                SubmitDate = DateTime.Now
            });
            Add(new Slech
            {
                Id = 3,
                Text = "Fun stuff for sure!!",
                Slecher = null,
                SubmitDate = DateTime.Now
            });
        }
    }
}