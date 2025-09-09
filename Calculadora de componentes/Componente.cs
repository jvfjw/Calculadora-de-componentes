using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_de_componentes
{
    public class Componente
    {
        public string? Nome { get; set; }
        public int Quantidade { get; set; }

        public string posicao { get; set; }

        public string? posicaoEstoque { get; set; }

        public override string ToString()
        {
            return $"{Nome}: {Quantidade}x";
        }

    }
}
