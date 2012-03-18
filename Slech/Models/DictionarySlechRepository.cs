using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Slech.Models
{
    public class DictionarySlechRepository : ISlechRepository
    {
        int nextID = 0;
        Dictionary<int, Slech> sleches = new Dictionary<int, Slech>(); 

        public IEnumerable<Slech> Get()
        {
            return sleches.Values.OrderByDescending(slech => slech.SubmitDate);
        }

        public bool TryGet(int id, out Slech slech)
        {
            return sleches.TryGetValue(id, out slech);
        }

        public Slech Add(Slech slech)
        {
            slech.Id = nextID++;
            sleches[slech.Id] = slech;
            return slech;
        }

        public bool Delete(int id)
        {
            return sleches.Remove(id);
        }

        public bool Update(Slech slech)
        {
            bool update = sleches.ContainsKey(slech.Id);
            sleches[slech.Id] = slech;
            return update;
        }
    }
}