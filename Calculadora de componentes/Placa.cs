using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_de_componentes
{
    public class Placa
    {
        public int ID { get; set; }
        public string? Nome { get; set; }
        public List<Componente> Componentes { get; set; } = new List<Componente>();
    

    public override string ToString()
        {
            return $"{Nome}";
        }
    
    
    }
}
