﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ajandekLista2
{
    class Ajandek
    {
        int id;
        string nev;
        string uzlet;

        public Ajandek(int id, string nev, string uzlet)
        {
            this.id = id;
            this.nev = nev;
            this.uzlet = uzlet;
        }

        public int Id { get => id;}
        public string Nev { get => nev; set => nev = value; }
        public string Uzlet { get => uzlet; set => uzlet = value; }

        public override string ToString()
        {
            return this.nev;
        }
    }
}
