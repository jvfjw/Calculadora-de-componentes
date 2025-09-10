using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System;
using Gui_calculadora.Model;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Xml.Linq;
namespace Gui_calculadora;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        this.DataContext = new MainViewModel();
    }

    private void MenuItem_Click_1(object sender, RoutedEventArgs e)
    {
        if (sender is MenuItem item && item.DataContext is Placa placa)
        {
      
        }
    }

    public class MainViewModel : INotifyPropertyChanged
    {
        private int _fatorGlobal = 1;
        private Placa? _placaSelecionada;

        public ObservableCollection<Placa> Placas { get; }

        public Placa? PlacaSelecionada
        {
            get => _placaSelecionada;
            set
            {
                _placaSelecionada = value;
                OnPropertyChanged(nameof(PlacaSelecionada));

                
                if (_placaSelecionada != null)
                    _placaSelecionada.FatorGlobal = FatorGlobal;
            }
        }

        public int FatorGlobal
        {
            get => _fatorGlobal;
            set
            {
                _fatorGlobal = value;
                OnPropertyChanged(nameof(FatorGlobal));

                if (PlacaSelecionada != null)
                    PlacaSelecionada.FatorGlobal = value;
            }
        }

        public MainViewModel()
        {
            //CARREGAMENTO DAS PLACAS
            var repo = new Repositorioplacas();
            Placas = repo.Placas;
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        private void OnPropertyChanged(string name) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }


    private void Button_Click_1(object sender, RoutedEventArgs e)
    {
       //IMPRESSÃO DA LISTA
        
        PrintDialog printDialog = new PrintDialog();
        if (printDialog.ShowDialog() == true)
        {
            printDialog.PrintTicket.PageOrientation = System.Printing.PageOrientation.Portrait;
            Size pageSize = new Size(printDialog.PrintableAreaWidth + 30, printDialog.PrintableAreaHeight + 300);
            Lista.Measure(pageSize);
            Lista.Arrange(new Rect(15, 15, pageSize.Height, pageSize.Width));
            printDialog.PrintVisual(Lista, "Job Card");
        }
    }


}
