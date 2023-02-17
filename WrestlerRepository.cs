using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WWE
{
    public class WrestlerRepository : IWrestlerRepository
    {
        private readonly List<Wrestler> _wrestlers;

        public WrestlerRepository(List<Wrestler> wrestlers)
        {
            _wrestlers = wrestlers;
        }

        public List<Wrestler> GetWrestlers()
        {
            return _wrestlers;
        }
    }
}
