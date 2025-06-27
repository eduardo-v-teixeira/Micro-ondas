using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Micro_ondas.Entities
{
    internal class Item
    {
        public string Nome { get; set; }
        public bool Aquecido { get; set; }

        public Item(string nome)
        {
            Nome = nome;
            Aquecido = false;
        }
    }
}
