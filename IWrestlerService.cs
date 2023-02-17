using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WWE
{
    /// <summary>
    /// The IWrestlerService interface defines a method for getting a list of wrestlers.
    /// </summary>
    public interface IWrestlerService
    {
        List<Wrestler> GetWrestlers();
    }
}
