using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DialogsSystem
{
    abstract class Character
    {
        public string pathSpeaksFile { get; set; }
        public string firstName { get; set; }
        public int Id { get; set; }
    }
}
