using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nim
{
    class Player
    {
        private int playernumber = 1;
        string Name { get; set; }
        public string getName()
        {
            return Name;
        }
        public void setName(string name)
        {
            if(name.Equals("")|| name.Equals(null))
            {
                Name = "Player " + playernumber;
            }
            else
            {
                Name = name;
            }
            playernumber++;
        }
    }
}
