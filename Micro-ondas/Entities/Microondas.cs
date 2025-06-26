namespace Micro_ondas.Entities
{
    class Microondas
    {
        public bool PortaAberta { get; set; }
        public bool AlimentoDentro { get; set; }
        public int Tempo { get; set; }
        public int Potencia { get; set; }
        public bool Aquecendo { get; set; }

        public Microondas(bool portaAberta, bool alimentoDentro, int tempo, int potencia, bool aquecendo)
        {
            PortaAberta = portaAberta;
            AlimentoDentro = alimentoDentro;
            Tempo = tempo;
            Potencia = potencia;
            Aquecendo = aquecendo;
        }

        public void AbrirPorta()
        {
            if (Aquecendo)
            {
                Console.WriteLine("Não pode abrir porta enquanto aquece!");
                return;
            }

            PortaAberta = true;
            Console.WriteLine("Porta aberta.");
        }

        public void FecharPorta()
        {
            PortaAberta = false;
            Console.WriteLine("Porta fechada.");
        }

        public void InserirAlimento()
        {
            if (!PortaAberta)
            {
                Console.WriteLine("Abra a porta primeiro!");
                return;
            }

            AlimentoDentro = true;
            Console.WriteLine("Alimento inserido.");
        }

        public void RetirarAlimento()
        {
            if (!PortaAberta)
            {
                Console.WriteLine("Abra a porta primeiro!");
                return;
            }

            AlimentoDentro = false;
            Console.WriteLine("Alimento retirado.");
        }

        public void DefinirTempo(int segundos)
        {
            if (segundos < 1 || segundos > 300)
            {
                Console.WriteLine("Tempo deve ser entre 1 e 300 segundos.");
                return;
            }

            Tempo = segundos;
            Console.WriteLine($"Tempo definido para {Tempo} segundos.");
        }

        public void DefinirPotencia(int potencia)
        {
            if (potencia < 1 || potencia > 10)
            {
                Console.WriteLine("Potencia deve ser entre 1 e 10.");
                return;
            }

            Potencia = potencia;
            Console.WriteLine($"Potencia definida para {Potencia}");
        }

        public void Iniciar()
        {
            if (PortaAberta)
            {
                Console.WriteLine("Feche a porta primeiro!");
                return;
            }

            if (!AlimentoDentro)
            {
                Console.WriteLine("Insira um alimento primeiro!");
                return;
            }

            if (Tempo == 0)
            {
                Console.WriteLine("Defina um tempo antes de iniciar!");
                return;
            }

            Aquecendo = true;
            Console.WriteLine($"Aquecendo por {Tempo} segundos na potência {Potencia}...");
            Aquecendo = false;
            Console.WriteLine("Aquicimento finalizado.");
        }

    }
}
