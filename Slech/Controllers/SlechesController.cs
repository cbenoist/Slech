using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Http;
using Slech.Models;
using Slech.Filters;

namespace Slech.Controllers
{
    public class SlechesController : ApiController
    {
        private static ISlechRepository repository;

        public SlechesController()
        {
            if (SlechesController.repository == null)
            {
                SlechesController.repository = new InitialData();
            }
        }

        public IQueryable<Models.Slech> GetSleches()
        {
            return repository.Get().AsQueryable();
        }
    }
}
