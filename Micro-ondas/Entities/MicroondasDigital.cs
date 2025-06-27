using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Micro_ondas.Entities
{
    internal class MicroondasDigital : IMicroondas
    {
        private bool PortaAberta { get; set; }
        private Item Item { get; set; }
        private int Tempo { get; set; }
        private int Potencia { get; set; }
        private bool EmAquecimento { get; set; }

        public MicroondasDigital(bool portaAberta, Item item, int tempo, int potencia, bool emAquecimento)
        {
            PortaAberta = false;
            Item = null;
            Tempo = 0;
            Potencia = 5;
            EmAquecimento = false;
        }

        


    }
}
