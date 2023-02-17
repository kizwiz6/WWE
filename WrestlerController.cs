using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WWE
{
    public class WrestlerController
    {
        private readonly IWrestlerService _wrestlerService;

        public WrestlerController(IWrestlerService wrestlerService)
        {
            _wrestlerService = wrestlerService;
        }

        public void DisplayWrestlers()
        {
            var wrestlers = _wrestlerService.GetWrestlers();

            Console.WriteLine("Wrestlers:");
            foreach (var wrestler in wrestlers)
            {
                Console.WriteLine($"Name: {wrestler.Name}, Nickname: {wrestler.Nickname}, Age: {wrestler.Age}");
            }
        }
    }
}
