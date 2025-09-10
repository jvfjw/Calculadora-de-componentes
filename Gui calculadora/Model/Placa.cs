using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gui_calculadora.Model
{
    public class Placa : INotifyPropertyChanged
{
    private int _fatorGlobal = 1;
    public int ID { get; set; }
    public string? Nome { get; set; }
    public ObservableCollection<Componente> Componentes { get; set; } = new();


    public int FatorGlobal
    {
        get => _fatorGlobal;
        set
        {
            _fatorGlobal = value;
            foreach (var c in Componentes)
                c.Fator = value; // repassa para cada componente
            OnPropertyChanged(nameof(FatorGlobal));
        }
    }

    public event PropertyChangedEventHandler? PropertyChanged;
    private void OnPropertyChanged(string name) =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

    public override string ToString()
    {
        return $"{Nome}";
    }

} } 
   

