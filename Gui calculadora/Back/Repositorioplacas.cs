using Calculadora_de_componentes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gui_calculadora.Back
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
                }

                


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

