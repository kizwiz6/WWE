using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WWE
{
    /// <summary>
    /// The IWrestlerRepository interface defines a method for getting a list of wrestlers.
    /// The WrestlerRepository class implements this interface and has a constructor that takes a list of wrestlers as a parameter. The GetWrestlers method returns the list of wrestlers.
    /// </summary>
    public interface IWrestlerRepository
    {
        List<Wrestler> GetWrestlers();
    }
}
