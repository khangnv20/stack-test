using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Song
    {
        private string ltype;
        private string name;
        private string time;

        public Song(string[] song)
        {
            this.ltype = song[0];
            this.name = song[1];
            this.time = song[2];
        }

        public string Time { get => time; set => time = value; }
        public string Ltype { get => ltype; set => ltype = value; }
        public string Name { get => name; set => name = value; }
    }
}
