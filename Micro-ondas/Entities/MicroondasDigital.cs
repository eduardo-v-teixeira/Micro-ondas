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

        public void AbrirPorta()
        {
            if (EmAquecimento)
            {
                Console.WriteLine("Não é possivel abrir a porta durante o aquecimento.");
                return;
            }

            PortaAberta = true;
            Console.WriteLine("Porta aberta");
        }

        public void FecharPorta()
        {
            PortaAberta = false;
            Console.WriteLine("Porta fechada");
        }
        public void InserirItem(string nomeItem)
        {
            if (!PortaAberta)
            {
                Console.WriteLine("Abra a porta antes de inserir o item.");
                return;
            }

            if (Item != null)
            {
                Console.WriteLine("Já existe um item dentro.");
                return;
            }

            Item = new Item(nomeItem);
            Console.WriteLine($"Item '{nomeItem}' inserido.");
        }

        public void RetirarItem()
        {
            if (!PortaAberta)
            {
                Console.WriteLine("Abra a porta antes de retirar o item.");
                return;
            }

            if (Item == null)
            {
                Console.WriteLine("Não há item para retirar.");
                return;
            }

            Console.WriteLine($"item '{Item.Nome}' retiradp. Aquecido: {Item.Aquecido}");
            Item = null;
        }

        public void configurar(int tempoSegundo, int potenciaNivel)
        {
            if (tempoSegundo < 1 || tempoSegundo > 600)
            {
                Console.WriteLine("Tempo deve ser entre 1 e 600 segundos.");
                return;
            }

            if (potenciaNivel < 1 || potenciaNivel > 10)
            {
                Console.WriteLine("Potencia deve ser entre 1 e 10.");
                return;
            }

            Tempo = tempoSegundo;
            Potencia = potenciaNivel;   
        }

    }
}
