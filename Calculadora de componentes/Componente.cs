using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_de_componentes
{
    public class Componente : INotifyPropertyChanged
    {
        private string? _nome;
        private int _quantidade;
        private int _fator = 1;

        public string? Nome
        {
            get 
            { 
                return _nome; 
            }
            set { _nome = value; OnPropertyChanged(nameof(Nome)); }
        }

        public int Quantidade
        {
            get 
            { 
                return _quantidade; 
            }
            set
            {
                _quantidade = value;
                OnPropertyChanged(nameof(Quantidade));
                OnPropertyChanged(nameof(QuantidadeFinal)); 
            }
        }

        public string? posicao { get; set; }
        public string? posicaoEstoque { get; set; }

        public int Fator
        {
            get 
            { 
                return _fator; 
            }
            set
            {
                _fator = value;
                OnPropertyChanged(nameof(Fator));
                OnPropertyChanged(nameof(QuantidadeFinal)); // notificar UI
            }
        }

        public int QuantidadeFinal { get { return Quantidade * Fator; } }

        public override string ToString()
        {
            return $"{Nome}: {QuantidadeFinal}x";
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        private void OnPropertyChanged(string propertyName) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}