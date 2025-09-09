using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_de_componentes
    {
        public class Dy8RL
        {
            public string nome { get; set; }
            int quantidade { get; set; }
            int reles { get; set; }
            int diodos { get; set; }
            int resistores { get; set; } = 1;
            int ledVerde { get; set; } = 1;
                 
        public List<Componente> Componentes8RL { get; set; }

        public Dy8RL(int quantia, int rele)
            {
                nome = $"Dy{rele}RL";
                quantidade = quantia;
                diodos = (rele + 1) * quantia;
                resistores = 1 * quantia;
                ledVerde = 1 * quantia;
                reles = (rele + 1) * quantia;
                List<Componente> componentes = new List<Componente>
                {
                    new Componente { Nome = "Relé SRD-05VDC", Quantidade = reles * quantia},
                    new Componente { Nome = "Diodo 1n4007", Quantidade = reles  * quantia},
                    new Componente { Nome = "Resistor 1k", Quantidade = resistores },
                    new Componente { Nome = "Led verde 3mm", Quantidade = ledVerde }
                };
            Componentes8RL = componentes;
        }
            public void ExibirComponentes()
            {
                Console.WriteLine($"Componentes necessários:\n" +
                    $"{quantidade * (reles + 1)} Relés\n" +
                    $"{quantidade * (diodos + 1)} Diodos\n" +
                    $"{quantidade * resistores} Resistores \n" +
                    $"{quantidade * ledVerde} Leds Verde \n");
            }

            public string quantiaLeds()
        {
            return ($" Led verde 3mm: {Convert.ToInt64(ledVerde)}x");
        }

        public string quantiaResistores()
        {
            return ($" Resistor 1k: {Convert.ToInt64(resistores)}x");
        }
        public string quantiaDiodos()
        {
            return ($" Diodo 1n4007: {Convert.ToInt64(diodos)}x");
        }
        public string quantiaReles()
        {
            return ($" Relé SRD-05VDC: {Convert.ToInt64(reles)}x");
        }


    }

    }
