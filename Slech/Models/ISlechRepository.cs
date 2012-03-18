using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Slech.Models
{
    public interface ISlechRepository
    {
        IEnumerable<Slech> Get();
        bool TryGet(int id, out Slech slech);
        Slech Add(Slech slech);
        bool Delete(int id);
        bool Update(Slech slech); 
    }
}
