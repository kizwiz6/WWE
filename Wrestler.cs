using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WWE
{
    public class Wrestler
    {
        public string Name { get; }
        public string Nickname { get; }
        public int Age { get; }

        public Wrestler(string name, string nickname, int age)
        {
            Name = name;
            Nickname = nickname;
            Age = age;
        }
    }
}
