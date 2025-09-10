using Calculadora_de_componentes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gui_calculadora.Model
{
    public class Repositorioplacas
    {

        public ObservableCollection<Placa> Placas { get; set; }

        private string nomePlaca;

        public string NomePlaca
        {
            get { return nomePlaca; }
            set { nomePlaca = value; }
        }

        public Repositorioplacas()
        {
            
            Placas = new ObservableCollection<Placa>
            {
                new Placa
                {
                    ID = 1,
                    Nome = "Dy8RL",
                    Componentes = new ObservableCollection<Componente>
                    {
                        new Componente { Nome = "Relé SRD-05VDC", Quantidade = 9, posicao = "RL1-RL9", posicaoEstoque = "F2/D2" },
                        new Componente { Nome = "Diodo 1n4007", Quantidade = 9, posicao = "D1-D9", posicaoEstoque = "F2" },
                        new Componente { Nome = "Resistor 1k", Quantidade = 1, posicao = "R1", posicaoEstoque = "B7" },
                        new Componente { Nome = "Led verde 3mm", Quantidade = 1, posicao = "LED1", posicaoEstoque = "A2" }
                    }
                },

                new Placa
                {
                    ID = 2,
                    Nome = "Dy7RL",
                    Componentes = new ObservableCollection<Componente>
                    {
                        new Componente { Nome = "Relé SRD-05VDC", Quantidade = 8, posicao = "RL1-RL7, RL9", posicaoEstoque = "F2/D2" },
                        new Componente { Nome = "Diodo 1n4007", Quantidade = 8, posicao = "D1-D7, D9", posicaoEstoque = "F2" },
                        new Componente { Nome = "Resistor 1k", Quantidade = 1, posicao = "R1", posicaoEstoque = "B7" },
                        new Componente { Nome = "Led verde 3mm", Quantidade = 1, posicao = "LED1", posicaoEstoque = "A2" }
                    }


                },

                new Placa
                {
                    ID = 3,
                    Nome = "Dy6RL",
                    Componentes = new ObservableCollection<Componente>
                    {
                        new Componente { Nome = "Relé SRD-05VDC", Quantidade = 7, posicao = "RL1-RL6, RL9", posicaoEstoque = "F2/D2" },
                        new Componente { Nome = "Diodo 1n4007", Quantidade = 7, posicao = "D1-D7, D9", posicaoEstoque = "F2" },
                        new Componente { Nome = "Resistor 1k", Quantidade = 1, posicao = "R1", posicaoEstoque = "B7" },
                        new Componente { Nome = "Led verde 3mm", Quantidade = 1, posicao = "LED1", posicaoEstoque = "A2" }
                    }


                },

                new Placa
                {
                    ID = 4,
                    Nome = "Dy5RL",
                    Componentes = new ObservableCollection<Componente>
                    {
                        new Componente { Nome = "Relé SRD-05VDC", Quantidade = 6, posicao = "RL1-RL5, RL9", posicaoEstoque = "F2/D2" },
                        new Componente { Nome = "Diodo 1n4007", Quantidade = 6, posicao = "D1-D6, D9", posicaoEstoque = "F2" },
                        new Componente { Nome = "Resistor 1k", Quantidade = 1, posicao = "R1", posicaoEstoque = "B7" },
                        new Componente { Nome = "Led verde 3mm", Quantidade = 1, posicao = "LED1", posicaoEstoque = "A2" }
                    }

                },

                new Placa
                {
                    ID = 5,
                    Nome = "Dy4RL",
                    Componentes = new ObservableCollection<Componente>
                    {
                        new Componente { Nome = "Relé SRD-05VDC", Quantidade = 5, posicao = "RL1-RL4 e RL9", posicaoEstoque = "F2/D2" },
                        new Componente { Nome = "Diodo 1n4007", Quantidade = 5, posicao = "D1-D4, D9", posicaoEstoque = "F2" },
                        new Componente { Nome = "Resistor 1k", Quantidade = 1, posicao = "R1", posicaoEstoque = "B7" },
                        new Componente { Nome = "Led verde 3mm", Quantidade = 1, posicao = "LED1", posicaoEstoque = "A2" }
                    }


                },

                new Placa
                {
                    ID = 6,
                    Nome = "Dy3RL",
                    Componentes = new ObservableCollection<Componente>
                    {
                        new Componente { Nome = "Relé SRD-05VDC", Quantidade = 4, posicao = "RL1-RL3 e RL9", posicaoEstoque = "F2/D2" },
                        new Componente { Nome = "Diodo 1n4007", Quantidade = 4, posicao = "D1-D3, D9", posicaoEstoque = "F2" },
                        new Componente { Nome = "Resistor 1k", Quantidade = 1, posicao = "R1", posicaoEstoque = "B7" },
                        new Componente { Nome = "Led verde 3mm", Quantidade = 1, posicao = "LED1", posicaoEstoque = "A2" }
                    }
                },

                new Placa
                {
                    ID = 7,
                    Nome = "Dy2RL",
                    Componentes = new ObservableCollection<Componente>
                    {
                        new Componente { Nome = "Relé SRD-05VDC", Quantidade = 3, posicao = "RL1, RL2 e RL9", posicaoEstoque = "F2/D2" },
                        new Componente { Nome = "Diodo 1n4007", Quantidade = 3, posicao = "D1, D2 e D9", posicaoEstoque = "F2" },
                        new Componente { Nome = "Resistor 1k", Quantidade = 1, posicao = "R1", posicaoEstoque = "B7" },
                        new Componente { Nome = "Led verde 3mm", Quantidade = 1, posicao = "LED1", posicaoEstoque = "A2" }
                    }
                },

                new Placa
                {
                    ID = 8,
                    Nome = "Dy1RL",
                    Componentes = new ObservableCollection<Componente>
                    {
                        new Componente { Nome = "Relé SRD-05VDC", Quantidade = 2, posicao = "RL1 e RL9", posicaoEstoque = "F2/D2" },
                        new Componente { Nome = "Diodo 1n4007", Quantidade = 2, posicao = "D1 e D9", posicaoEstoque = "F2" },
                        new Componente { Nome = "Resistor 1k", Quantidade = 1, posicao = "R1", posicaoEstoque = "B7" },
                        new Componente { Nome = "Led verde 3mm", Quantidade = 1, posicao = "LED1", posicaoEstoque = "A2" }
                    }
                },

                new Placa
                {
                    ID = 9,
                    Nome = "P128 8 Slots",
                    Componentes = new ObservableCollection<Componente>
                    {
                        new Componente { Nome = "Capacitor Elco Radial 4,7uF/50v", Quantidade =1, posicao = "C1", posicaoEstoque = "A4" },
                        new Componente { Nome = "Diodo 1n4007", Quantidade = 5, posicao = "D1-D5", posicaoEstoque = "D2/F2" },
                        new Componente { Nome = "Conector Borne KRE 2 vias", Quantidade =2, posicao = "PWR", posicaoEstoque = "E6/F2" },
                        new Componente { Nome = "Conector Jack (JACK_3P)", Quantidade =1, posicao = "JPWR", posicaoEstoque = "A1" },
                        new Componente { Nome = "Conector MCI 2x13", Quantidade =8, posicao = "DY1-DY8", posicaoEstoque = "G3" },
                        new Componente { Nome = "Conector MCI 2X20", Quantidade =1, posicao = "CN1", posicaoEstoque = "A5/G3" },
                        new Componente { Nome = "Led Verde 3mm", Quantidade =1, posicao = "ALIMENTAÇÃO", posicaoEstoque = "A2" },
                        new Componente { Nome = "Led vermelho 3mm", Quantidade =2, posicao = "CONTROLE, PAR-IMPAR", posicaoEstoque = "A2" },
                        new Componente { Nome = "PCI P128", Quantidade =1, posicao = "", posicaoEstoque = "l1" },
                        new Componente { Nome = "Relé Metaltex 12v", Quantidade =1, posicao = "RL2", posicaoEstoque = "E8/G1" },
                        new Componente { Nome = "Relé metaltex 5v", Quantidade =1, posicao = "RL1", posicaoEstoque = "D1/F1" },
                        new Componente { Nome = "Resistor 100R 1/4W 5%", Quantidade =1, posicao = "R6", posicaoEstoque = "C3" },
                        new Componente { Nome = "Resistor 10k 1/4W 5%", Quantidade =2, posicao = "R4-R5", posicaoEstoque = "B7" },
                        new Componente { Nome = "Resistor 1k 1/4W 5%", Quantidade =4, posicao = "R1-R3, R8", posicaoEstoque = "B7/F2"},
                        new Componente { Nome = "Resistor 3k3- 1/4W 5%", Quantidade =1, posicao = "R7", posicaoEstoque = "B7" },
                        new Componente { Nome = "Transístor BC517", Quantidade =1, posicao = "Q1", posicaoEstoque = "B2" },
                    }
                },

                new Placa
                {
                    ID = 10,
                    Nome = "P128 7 Slots",
                    Componentes = new ObservableCollection<Componente>
                    {
                        new Componente { Nome = "Capacitor Elco Radial 4,7uF/50v", Quantidade =1, posicao = "C1", posicaoEstoque = "A4" },
                        new Componente { Nome = "Diodo 1n4007", Quantidade = 5, posicao = "D1-D5", posicaoEstoque = "D2/F2" },
                        new Componente { Nome = "Conector Borne KRE 2 vias", Quantidade =2, posicao = "PWR", posicaoEstoque = "E6/F2" },
                        new Componente { Nome = "Conector Jack (JACK_3P)", Quantidade =1, posicao = "JPWR", posicaoEstoque = "A1" },
                        new Componente { Nome = "Conector MCI 2x13", Quantidade =7, posicao = "DY1-DY8", posicaoEstoque = "G3" },
                        new Componente { Nome = "Conector MCI 2X20", Quantidade =1, posicao = "CN1", posicaoEstoque = "A5/G3" },
                        new Componente { Nome = "Led Verde 3mm", Quantidade =1, posicao = "ALIMENTAÇÃO", posicaoEstoque = "A2" },
                        new Componente { Nome = "Led vermelho 3mm", Quantidade =2, posicao = "CONTROLE, PAR-IMPAR", posicaoEstoque = "A2" },
                        new Componente { Nome = "PCI P128", Quantidade =1, posicao = "", posicaoEstoque = "l1" },
                        new Componente { Nome = "Relé Metaltex 12v", Quantidade =1, posicao = "RL2", posicaoEstoque = "E8/G1" },
                        new Componente { Nome = "Relé metaltex 5v", Quantidade =1, posicao = "RL1", posicaoEstoque = "D1/F1" },
                        new Componente { Nome = "Resistor 100R 1/4W 5%", Quantidade =1, posicao = "R6", posicaoEstoque = "C3" },
                        new Componente { Nome = "Resistor 10k 1/4W 5%", Quantidade =2, posicao = "R4-R5", posicaoEstoque = "B7" },
                        new Componente { Nome = "Resistor 1k 1/4W 5%", Quantidade =4, posicao = "R1-R3, R8", posicaoEstoque = "B7/F2"},
                        new Componente { Nome = "Resistor 3k3- 1/4W 5%", Quantidade =1, posicao = "R7", posicaoEstoque = "B7" },
                        new Componente { Nome = "Transístor BC517", Quantidade =1, posicao = "Q1", posicaoEstoque = "B2" },
                    }
                },

                new Placa
                {
                    ID = 11,
                    Nome = "P128 6 Slots",
                    Componentes = new ObservableCollection<Componente>
                    {
                        new Componente { Nome = "Capacitor Elco Radial 4,7uF/50v", Quantidade =1, posicao = "C1", posicaoEstoque = "A4" },
                        new Componente { Nome = "Diodo 1n4007", Quantidade = 5, posicao = "D1-D5", posicaoEstoque = "D2/F2" },
                        new Componente { Nome = "Conector Borne KRE 2 vias", Quantidade =2, posicao = "PWR", posicaoEstoque = "E6/F2" },
                        new Componente { Nome = "Conector Jack (JACK_3P)", Quantidade =1, posicao = "JPWR", posicaoEstoque = "A1" },
                        new Componente { Nome = "Conector MCI 2x13", Quantidade =6, posicao = "DY1-DY8", posicaoEstoque = "G3" },
                        new Componente { Nome = "Conector MCI 2X20", Quantidade =1, posicao = "CN1", posicaoEstoque = "A5/G3" },
                        new Componente { Nome = "Led Verde 3mm", Quantidade =1, posicao = "ALIMENTAÇÃO", posicaoEstoque = "A2" },
                        new Componente { Nome = "Led vermelho 3mm", Quantidade =2, posicao = "CONTROLE, PAR-IMPAR", posicaoEstoque = "A2" },
                        new Componente { Nome = "PCI P128", Quantidade =1, posicao = "", posicaoEstoque = "l1" },
                        new Componente { Nome = "Relé Metaltex 12v", Quantidade =1, posicao = "RL2", posicaoEstoque = "E8/G1" },
                        new Componente { Nome = "Relé metaltex 5v", Quantidade =1, posicao = "RL1", posicaoEstoque = "D1/F1" },
                        new Componente { Nome = "Resistor 100R 1/4W 5%", Quantidade =1, posicao = "R6", posicaoEstoque = "C3" },
                        new Componente { Nome = "Resistor 10k 1/4W 5%", Quantidade =2, posicao = "R4-R5", posicaoEstoque = "B7" },
                        new Componente { Nome = "Resistor 1k 1/4W 5%", Quantidade =4, posicao = "R1-R3, R8", posicaoEstoque = "B7/F2"},
                        new Componente { Nome = "Resistor 3k3- 1/4W 5%", Quantidade =1, posicao = "R7", posicaoEstoque = "B7" },
                        new Componente { Nome = "Transístor BC517", Quantidade =1, posicao = "Q1", posicaoEstoque = "B2" },
                    }
                },

                new Placa
                {
                    ID = 12,
                    Nome = "P128 5 Slots",
                    Componentes = new ObservableCollection<Componente>
                    {
                        new Componente { Nome = "Capacitor Elco Radial 4,7uF/50v", Quantidade =1, posicao = "C1", posicaoEstoque = "A4" },
                        new Componente { Nome = "Diodo 1n4007", Quantidade = 5, posicao = "D1-D5", posicaoEstoque = "D2/F2" },
                        new Componente { Nome = "Conector Borne KRE 2 vias", Quantidade =2, posicao = "PWR", posicaoEstoque = "E6/F2" },
                        new Componente { Nome = "Conector Jack (JACK_3P)", Quantidade =1, posicao = "JPWR", posicaoEstoque = "A1" },
                        new Componente { Nome = "Conector MCI 2x13", Quantidade =5, posicao = "DY1-DY8", posicaoEstoque = "G3" },
                        new Componente { Nome = "Conector MCI 2X20", Quantidade =1, posicao = "CN1", posicaoEstoque = "A5/G3" },
                        new Componente { Nome = "Led Verde 3mm", Quantidade =1, posicao = "ALIMENTAÇÃO", posicaoEstoque = "A2" },
                        new Componente { Nome = "Led vermelho 3mm", Quantidade =2, posicao = "CONTROLE, PAR-IMPAR", posicaoEstoque = "A2" },
                        new Componente { Nome = "PCI P128", Quantidade =1, posicao = "", posicaoEstoque = "l1" },
                        new Componente { Nome = "Relé Metaltex 12v", Quantidade =1, posicao = "RL2", posicaoEstoque = "E8/G1" },
                        new Componente { Nome = "Relé metaltex 5v", Quantidade =1, posicao = "RL1", posicaoEstoque = "D1/F1" },
                        new Componente { Nome = "Resistor 100R 1/4W 5%", Quantidade =1, posicao = "R6", posicaoEstoque = "C3" },
                        new Componente { Nome = "Resistor 10k 1/4W 5%", Quantidade =2, posicao = "R4-R5", posicaoEstoque = "B7" },
                        new Componente { Nome = "Resistor 1k 1/4W 5%", Quantidade =4, posicao = "R1-R3, R8", posicaoEstoque = "B7/F2"},
                        new Componente { Nome = "Resistor 3k3- 1/4W 5%", Quantidade =1, posicao = "R7", posicaoEstoque = "B7" },
                        new Componente { Nome = "Transístor BC517", Quantidade =1, posicao = "Q1", posicaoEstoque = "B2" },
                    }
                },

                new Placa
                {
                    ID = 13,
                    Nome = "P128 4 Slots",
                    Componentes = new ObservableCollection<Componente>
                    {
                        new Componente { Nome = "Capacitor Elco Radial 4,7uF/50v", Quantidade =1, posicao = "C1", posicaoEstoque = "A4" },
                        new Componente { Nome = "Diodo 1n4007", Quantidade = 5, posicao = "D1-D5", posicaoEstoque = "D2/F2" },
                        new Componente { Nome = "Conector Borne KRE 2 vias", Quantidade =2, posicao = "PWR", posicaoEstoque = "E6/F2" },
                        new Componente { Nome = "Conector Jack (JACK_3P)", Quantidade =1, posicao = "JPWR", posicaoEstoque = "A1" },
                        new Componente { Nome = "Conector MCI 2x13", Quantidade =4, posicao = "DY1-DY8", posicaoEstoque = "G3" },
                        new Componente { Nome = "Conector MCI 2X20", Quantidade =1, posicao = "CN1", posicaoEstoque = "A5/G3" },
                        new Componente { Nome = "Led Verde 3mm", Quantidade =1, posicao = "ALIMENTAÇÃO", posicaoEstoque = "A2" },
                        new Componente { Nome = "Led vermelho 3mm", Quantidade =2, posicao = "CONTROLE, PAR-IMPAR", posicaoEstoque = "A2" },
                        new Componente { Nome = "PCI P128", Quantidade =1, posicao = "", posicaoEstoque = "l1" },
                        new Componente { Nome = "Relé Metaltex 12v", Quantidade =1, posicao = "RL2", posicaoEstoque = "E8/G1" },
                        new Componente { Nome = "Relé metaltex 5v", Quantidade =1, posicao = "RL1", posicaoEstoque = "D1/F1" },
                        new Componente { Nome = "Resistor 100R 1/4W 5%", Quantidade =1, posicao = "R6", posicaoEstoque = "C3" },
                        new Componente { Nome = "Resistor 10k 1/4W 5%", Quantidade =2, posicao = "R4-R5", posicaoEstoque = "B7" },
                        new Componente { Nome = "Resistor 1k 1/4W 5%", Quantidade =4, posicao = "R1-R3, R8", posicaoEstoque = "B7/F2"},
                        new Componente { Nome = "Resistor 3k3- 1/4W 5%", Quantidade =1, posicao = "R7", posicaoEstoque = "B7" },
                        new Componente { Nome = "Transístor BC517", Quantidade =1, posicao = "Q1", posicaoEstoque = "B2" },
                    }
                },

                new Placa
                {
                    ID = 14,
                    Nome = "P128 3 Slots",
                    Componentes = new ObservableCollection<Componente>
                    {
                        new Componente { Nome = "Capacitor Elco Radial 4,7uF/50v", Quantidade =1, posicao = "C1", posicaoEstoque = "A4" },
                        new Componente { Nome = "Diodo 1n4007", Quantidade = 5, posicao = "D1-D5", posicaoEstoque = "D2/F2" },
                        new Componente { Nome = "Conector Borne KRE 2 vias", Quantidade =2, posicao = "PWR", posicaoEstoque = "E6/F2" },
                        new Componente { Nome = "Conector Jack (JACK_3P)", Quantidade =1, posicao = "JPWR", posicaoEstoque = "A1" },
                        new Componente { Nome = "Conector MCI 2x13", Quantidade =3, posicao = "DY1-DY8", posicaoEstoque = "G3" },
                        new Componente { Nome = "Conector MCI 2X20", Quantidade =1, posicao = "CN1", posicaoEstoque = "A5/G3" },
                        new Componente { Nome = "Led Verde 3mm", Quantidade =1, posicao = "ALIMENTAÇÃO", posicaoEstoque = "A2" },
                        new Componente { Nome = "Led vermelho 3mm", Quantidade =2, posicao = "CONTROLE, PAR-IMPAR", posicaoEstoque = "A2" },
                        new Componente { Nome = "PCI P128", Quantidade =1, posicao = "", posicaoEstoque = "l1" },
                        new Componente { Nome = "Relé Metaltex 12v", Quantidade =1, posicao = "RL2", posicaoEstoque = "E8/G1" },
                        new Componente { Nome = "Relé metaltex 5v", Quantidade =1, posicao = "RL1", posicaoEstoque = "D1/F1" },
                        new Componente { Nome = "Resistor 100R 1/4W 5%", Quantidade =1, posicao = "R6", posicaoEstoque = "C3" },
                        new Componente { Nome = "Resistor 10k 1/4W 5%", Quantidade =2, posicao = "R4-R5", posicaoEstoque = "B7" },
                        new Componente { Nome = "Resistor 1k 1/4W 5%", Quantidade =4, posicao = "R1-R3, R8", posicaoEstoque = "B7/F2"},
                        new Componente { Nome = "Resistor 3k3- 1/4W 5%", Quantidade =1, posicao = "R7", posicaoEstoque = "B7" },
                        new Componente { Nome = "Transístor BC517", Quantidade =1, posicao = "Q1", posicaoEstoque = "B2" },
                    }
                },

                new Placa
                {
                    ID = 15,
                    Nome = "P128 2 Slots",
                    Componentes = new ObservableCollection<Componente>
                    {
                        new Componente { Nome = "Capacitor Elco Radial 4,7uF/50v", Quantidade =1, posicao = "C1", posicaoEstoque = "A4" },
                        new Componente { Nome = "Diodo 1n4007", Quantidade = 5, posicao = "D1-D5", posicaoEstoque = "D2/F2" },
                        new Componente { Nome = "Conector Borne KRE 2 vias", Quantidade =2, posicao = "PWR", posicaoEstoque = "E6/F2" },
                        new Componente { Nome = "Conector Jack (JACK_3P)", Quantidade =1, posicao = "JPWR", posicaoEstoque = "A1" },
                        new Componente { Nome = "Conector MCI 2x13", Quantidade =2, posicao = "DY1-DY8", posicaoEstoque = "G3" },
                        new Componente { Nome = "Conector MCI 2X20", Quantidade =1, posicao = "CN1", posicaoEstoque = "A5/G3" },
                        new Componente { Nome = "Led Verde 3mm", Quantidade =1, posicao = "ALIMENTAÇÃO", posicaoEstoque = "A2" },
                        new Componente { Nome = "Led vermelho 3mm", Quantidade =2, posicao = "CONTROLE, PAR-IMPAR", posicaoEstoque = "A2" },
                        new Componente { Nome = "PCI P128", Quantidade =1, posicao = "", posicaoEstoque = "l1" },
                        new Componente { Nome = "Relé Metaltex 12v", Quantidade =1, posicao = "RL2", posicaoEstoque = "E8/G1" },
                        new Componente { Nome = "Relé metaltex 5v", Quantidade =1, posicao = "RL1", posicaoEstoque = "D1/F1" },
                        new Componente { Nome = "Resistor 100R 1/4W 5%", Quantidade =1, posicao = "R6", posicaoEstoque = "C3" },
                        new Componente { Nome = "Resistor 10k 1/4W 5%", Quantidade =2, posicao = "R4-R5", posicaoEstoque = "B7" },
                        new Componente { Nome = "Resistor 1k 1/4W 5%", Quantidade =4, posicao = "R1-R3, R8", posicaoEstoque = "B7/F2"},
                        new Componente { Nome = "Resistor 3k3- 1/4W 5%", Quantidade =1, posicao = "R7", posicaoEstoque = "B7" },
                        new Componente { Nome = "Transístor BC517", Quantidade =1, posicao = "Q1", posicaoEstoque = "B2" },
                    }
                },

                new Placa
                {
                    ID = 16,
                    Nome = "P128 1 Slot",
                    Componentes = new ObservableCollection<Componente>
                    {
                        new Componente { Nome = "Capacitor Elco Radial 4,7uF/50v", Quantidade =1, posicao = "C1", posicaoEstoque = "A4" },
                        new Componente { Nome = "Diodo 1n4007", Quantidade = 5, posicao = "D1-D5", posicaoEstoque = "D2/F2" },
                        new Componente { Nome = "Conector Borne KRE 2 vias", Quantidade =2, posicao = "PWR", posicaoEstoque = "E6/F2" },
                        new Componente { Nome = "Conector Jack (JACK_3P)", Quantidade =1, posicao = "JPWR", posicaoEstoque = "A1" },
                        new Componente { Nome = "Conector MCI 2x13", Quantidade =1, posicao = "DY1-DY8", posicaoEstoque = "G3" },
                        new Componente { Nome = "Conector MCI 2X20", Quantidade =1, posicao = "CN1", posicaoEstoque = "A5/G3" },
                        new Componente { Nome = "Led Verde 3mm", Quantidade =1, posicao = "ALIMENTAÇÃO", posicaoEstoque = "A2" },
                        new Componente { Nome = "Led vermelho 3mm", Quantidade =2, posicao = "CONTROLE, PAR-IMPAR", posicaoEstoque = "A2" },
                        new Componente { Nome = "PCI P128", Quantidade =1, posicao = "", posicaoEstoque = "l1" },
                        new Componente { Nome = "Relé Metaltex 12v", Quantidade =1, posicao = "RL2", posicaoEstoque = "E8/G1" },
                        new Componente { Nome = "Relé metaltex 5v", Quantidade =1, posicao = "RL1", posicaoEstoque = "D1/F1" },
                        new Componente { Nome = "Resistor 100R 1/4W 5%", Quantidade =1, posicao = "R6", posicaoEstoque = "C3" },
                        new Componente { Nome = "Resistor 10k 1/4W 5%", Quantidade =2, posicao = "R4-R5", posicaoEstoque = "B7" },
                        new Componente { Nome = "Resistor 1k 1/4W 5%", Quantidade =4, posicao = "R1-R3, R8", posicaoEstoque = "B7/F2"},
                        new Componente { Nome = "Resistor 3k3- 1/4W 5%", Quantidade =1, posicao = "R7", posicaoEstoque = "B7" },
                        new Componente { Nome = "Transístor BC517", Quantidade =1, posicao = "Q1", posicaoEstoque = "B2" },
                    }
                },


                


                /*public static List<Placa> CriarPlacas()
                {
                    return new List<Placa>
                    {
                    new Placa
                    {
                        ID = 1,
                        Nome = "Dy8RL",
                        Componentes = new List<Componente>
                        {
                            new Componente { Nome = "Relé SRD-05VDC", Quantidade = 9, posicao = "RL1-RL9", posicaoEstoque = "F2/D2" },
                            new Componente { Nome = "Diodo 1n4007", Quantidade = 9, posicao = "D1-D9", posicaoEstoque = "F2" },
                            new Componente { Nome = "Resistor 1k", Quantidade = 1, posicao = "R1", posicaoEstoque = "B7" },
                            new Componente { Nome = "Led verde 3mm", Quantidade = 1, posicao = "LED1", posicaoEstoque = "A2" }
                        }
                    },

                    new Placa
                    {
                        ID = 2,
                        Nome = "Dy7RL",
                        Componentes = new List<Componente>
                        {
                            new Componente { Nome = "Relé SRD-05VDC", Quantidade = 8, posicao = "RL1-RL7, RL9", posicaoEstoque = "F2/D2" },
                            new Componente { Nome = "Diodo 1n4007", Quantidade = 8, posicao = "D1-D7, D9", posicaoEstoque = "F2" },
                            new Componente { Nome = "Resistor 1k", Quantidade = 1, posicao = "R1", posicaoEstoque = "B7" },
                            new Componente { Nome = "Led verde 3mm", Quantidade = 1, posicao = "LED1", posicaoEstoque = "A2" }
                        }


                    },

                    new Placa
                    {
                        ID = 3,
                        Nome = "Dy6RL",
                        Componentes = new List<Componente>
                        {
                            new Componente { Nome = "Relé SRD-05VDC", Quantidade = 7, posicao = "RL1-RL6, RL9", posicaoEstoque = "F2/D2" },
                            new Componente { Nome = "Diodo 1n4007", Quantidade = 7, posicao = "D1-D7, D9", posicaoEstoque = "F2" },
                            new Componente { Nome = "Resistor 1k", Quantidade = 1, posicao = "R1", posicaoEstoque = "B7" },
                            new Componente { Nome = "Led verde 3mm", Quantidade = 1, posicao = "LED1", posicaoEstoque = "A2" }
                        }


                    },

                    new Placa
                    {
                        ID = 4,
                        Nome = "Dy5RL",
                        Componentes = new List<Componente>
                        {
                            new Componente { Nome = "Relé SRD-05VDC", Quantidade = 6, posicao = "RL1-RL5, RL9", posicaoEstoque = "F2/D2" },
                            new Componente { Nome = "Diodo 1n4007", Quantidade = 6, posicao = "D1-D6, D9", posicaoEstoque = "F2" },
                            new Componente { Nome = "Resistor 1k", Quantidade = 1, posicao = "R1", posicaoEstoque = "B7" },
                            new Componente { Nome = "Led verde 3mm", Quantidade = 1, posicao = "LED1", posicaoEstoque = "A2" }
                        }

                    },

                    new Placa
                    {
                        ID = 2,
                        Nome = "Dy4RL",
                        Componentes = new List<Componente>
                        {
                            new Componente { Nome = "Relé SRD-05VDC", Quantidade = 5, posicao = "RL1-RL4 e RL9", posicaoEstoque = "F2/D2" },
                            new Componente { Nome = "Diodo 1n4007", Quantidade = 5, posicao = "D1-D4, D9", posicaoEstoque = "F2" },
                            new Componente { Nome = "Resistor 1k", Quantidade = 1, posicao = "R1", posicaoEstoque = "B7" },
                            new Componente { Nome = "Led verde 3mm", Quantidade = 1, posicao = "LED1", posicaoEstoque = "A2" }
                        }


                    },

                    new Placa
                    {
                        ID = 3,
                        Nome = "Dy3RL",
                        Componentes = new List<Componente>
                        {
                            new Componente { Nome = "Relé SRD-05VDC", Quantidade = 4, posicao = "RL1-RL3 e RL9", posicaoEstoque = "F2/D2" },
                            new Componente { Nome = "Diodo 1n4007", Quantidade = 4, posicao = "D1-D3, D9", posicaoEstoque = "F2" },
                            new Componente { Nome = "Resistor 1k", Quantidade = 1, posicao = "R1", posicaoEstoque = "B7" },
                            new Componente { Nome = "Led verde 3mm", Quantidade = 1, posicao = "LED1", posicaoEstoque = "A2" }
                        }
                    },

                    new Placa
                    {
                        ID = 4,
                        Nome = "Dy2RL",
                        Componentes = new List<Componente>
                        {
                            new Componente { Nome = "Relé SRD-05VDC", Quantidade = 3, posicao = "RL1, RL2 e RL9", posicaoEstoque = "F2/D2" },
                            new Componente { Nome = "Diodo 1n4007", Quantidade = 3, posicao = "D1, D2 e D9", posicaoEstoque = "F2" },
                            new Componente { Nome = "Resistor 1k", Quantidade = 1, posicao = "R1", posicaoEstoque = "B7" },
                            new Componente { Nome = "Led verde 3mm", Quantidade = 1, posicao = "LED1", posicaoEstoque = "A2" }
                        }
                    },

                    new Placa
                    {
                        ID = 5,
                        Nome = "Dy1RL",
                        Componentes = new List<Componente>
                        {
                            new Componente { Nome = "Relé SRD-05VDC", Quantidade = 2, posicao = "RL1 e RL9", posicaoEstoque = "F2/D2" },
                            new Componente { Nome = "Diodo 1n4007", Quantidade = 2, posicao = "D1 e D9", posicaoEstoque = "F2" },
                            new Componente { Nome = "Resistor 1k", Quantidade = 1, posicao = "R1", posicaoEstoque = "B7" },
                            new Componente { Nome = "Led verde 3mm", Quantidade = 1, posicao = "LED1", posicaoEstoque = "A2" }
                        }
                    }





                };*/
            };
        }

    } }   

