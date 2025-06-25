using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Micro_ondas.Entities.Function
{
    class Functionality
    {
        public bool Ligar { get; set; }
        public bool PortaAberta { get; set; }
        public int Tempo { get; set; }
        public int Potencia { get; set; }

        public Functionality(bool ligar, bool portaAberta, int tempo, int potencia)
        {
            Ligar = ligar;
            PortaAberta = portaAberta;
            Tempo = tempo;
            Potencia = potencia;
        }


    }
}
