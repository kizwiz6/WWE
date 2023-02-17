using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WWE
{
    /// <summary>
    /// The WrestlerService class implements this interface.
    /// </summary>
    public class WrestlerService : IWrestlerService
    {
        private readonly IWrestlerRepository _wrestlerRepository;

        public WrestlerService(IWrestlerRepository wrestlerRepository)
        {
            _wrestlerRepository = wrestlerRepository;
        }

        public List<Wrestler> GetWrestlers()
        {
            return _wrestlerRepository.GetWrestlers();
        }
    }
}
