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
using Calculadora_de_componentes;
using Gui_calculadora.Back;
using System.Collections.ObjectModel;
using System.ComponentModel;
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

    //PROPRIEDADES  




    private void Button_Click(object sender, RoutedEventArgs e)
    {
        if (Lista.Visibility == Visibility.Hidden)
            Lista.Visibility = Visibility.Visible;
        else
            Lista.Visibility = Visibility.Hidden;
        
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
            var repo = new Repositorioplacas();
            Placas = repo.Placas;
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        private void OnPropertyChanged(string name) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }



    /*  private string resistor1k;

      public string Resistor1k
      {
          get { return resistor1k; }
          set { resistor1k = value;
              Caixa1.Text = Resistor1k; }

      }

      private string diodo1n4007;
      public string Diodo1n4007
      {
          get { return diodo1n4007; }
          set { diodo1n4007 = value; Caixa2.Text = Diodo1n4007; }
      }

      private string ledVerde3mm;
      public string LedVerde3mm
      {
          get { return ledVerde3mm; }
          set { ledVerde3mm = value; Caixa3.Text = LedVerde3mm; }
      }

      private string releSRD05VDC;
      public string ReleSRD05VDC
      {
          get { return releSRD05VDC; }
          set { releSRD05VDC = value; Caixa4.Text = ReleSRD05VDC; }
      }



      //PROPRIEDADES

      private void opcao_Click(object sender, RoutedEventArgs e)
      {

      }


      private void MenuItem_Click(object sender, RoutedEventArgs e)
      {
          int quantia;
          if (InputQuantidade.Text == null || InputQuantidade.Text.Trim() == "" )
          {
              MessageBox.Show("Por favor, insira uma quantidade válida.");
              return;
          }
          else 
          { 
              quantia = int.Parse(InputQuantidade.Text);
              Escolha = "Dy8rl 8 Relés";
          }

          Dy8RL dy8RL = new Dy8RL(quantia, 8);

          LedVerde3mm = dy8RL.quantiaLeds() ;
          Resistor1k = dy8RL.quantiaResistores();
          Diodo1n4007 = dy8RL.quantiaDiodos();
          ReleSRD05VDC = dy8RL.quantiaReles();
      }

      private void MenuItem_Click_1(object sender, RoutedEventArgs e)
      {

          int quantia;
          if (InputQuantidade.Text == null || InputQuantidade.Text.Trim() == "")
          {
              MessageBox.Show("Por favor, insira uma quantidade válida.");
              return;
          }
          else 
          { 
              quantia = int.Parse(InputQuantidade.Text);
              Escolha = "Dy8rl 7 Relés";
          }

          Dy8RL dy8RL = new Dy8RL(quantia, 7);

          LedVerde3mm = dy8RL.quantiaLeds();
          Resistor1k = dy8RL.quantiaResistores();
          Diodo1n4007 = dy8RL.quantiaDiodos();
          ReleSRD05VDC = dy8RL.quantiaReles();
      }

      private void MenuItem_Click_2(object sender, RoutedEventArgs e)
      {

          int quantia;
          if (InputQuantidade.Text == null || InputQuantidade.Text.Trim() == "")
          {
              MessageBox.Show("Por favor, insira uma quantidade válida.");
              return;
          }
          else 
          { 
              quantia = int.Parse(InputQuantidade.Text);
              Escolha = "Dy8rl 6 Relés";
          }

          Dy8RL dy8RL = new Dy8RL(quantia, 6);

          LedVerde3mm = dy8RL.quantiaLeds();
          Resistor1k = dy8RL.quantiaResistores();
          Diodo1n4007 = dy8RL.quantiaDiodos();
          ReleSRD05VDC = dy8RL.quantiaReles();
      }

      private void MenuItem_Click_3(object sender, RoutedEventArgs e)
      {

          int quantia;
          if (InputQuantidade.Text == null || InputQuantidade.Text.Trim() == "")
          {
              MessageBox.Show("Por favor, insira uma quantidade válida.");
              return;
          }
          else 
          { 
              quantia = int.Parse(InputQuantidade.Text);
              Escolha = "Dy8rl 5 Relés";
          }

          Dy8RL dy8RL = new Dy8RL(quantia, 5);

          LedVerde3mm = dy8RL.quantiaLeds();
          Resistor1k = dy8RL.quantiaResistores();
          Diodo1n4007 = dy8RL.quantiaDiodos();
          ReleSRD05VDC = dy8RL.quantiaReles();
      }

      private void MenuItem_Click_4(object sender, RoutedEventArgs e)
      {

          int quantia;
          if (InputQuantidade.Text == null || InputQuantidade.Text.Trim() == "")
          {
              MessageBox.Show("Por favor, insira uma quantidade válida.");
              return;
          }
          else 
          { 
              quantia = int.Parse(InputQuantidade.Text);
              Escolha = "Dy8rl 4 Relés";
          }

          Dy8RL dy8RL = new Dy8RL(quantia, 4);

          LedVerde3mm = dy8RL.quantiaLeds();
          Resistor1k = dy8RL.quantiaResistores();
          Diodo1n4007 = dy8RL.quantiaDiodos();
          ReleSRD05VDC = dy8RL.quantiaReles();
      }

      private void MenuItem_Click_5(object sender, RoutedEventArgs e)
      {

          int quantia;
          if (InputQuantidade.Text == null || InputQuantidade.Text.Trim() == "")
          {
              MessageBox.Show("Por favor, insira uma quantidade válida.");
              return;
          }
          else 
          { 
              quantia = int.Parse(InputQuantidade.Text);
              Escolha = "Dy8rl 3 Relés";
          }

          Dy8RL dy8RL = new Dy8RL(quantia, 3);

          LedVerde3mm = dy8RL.quantiaLeds();
          Resistor1k = dy8RL.quantiaResistores();
          Diodo1n4007 = dy8RL.quantiaDiodos();
          ReleSRD05VDC = dy8RL.quantiaReles();
      }

      private void MenuItem_Click_6(object sender, RoutedEventArgs e)
      {
          int quantia;
          if (InputQuantidade.Text == null || InputQuantidade.Text.Trim() == "")
          {
              MessageBox.Show("Por favor, insira uma quantidade válida.");
              return;
          }
          else 
          {
              quantia = int.Parse(InputQuantidade.Text);
              Escolha = "Dy8rl 2 Relés";
          }

          Dy8RL dy8RL = new Dy8RL(quantia, 2);

          LedVerde3mm = dy8RL.quantiaLeds();
          Resistor1k = dy8RL.quantiaResistores();
          Diodo1n4007 = dy8RL.quantiaDiodos();
          ReleSRD05VDC = dy8RL.quantiaReles();
      }

      private void MenuItem_Click_7(object sender, RoutedEventArgs e)
      {

          int quantia;
          if (InputQuantidade.Text == null || InputQuantidade.Text.Trim() == "")
          {
              MessageBox.Show("Por favor, insira uma quantidade válida.");
              return;
          }
          else 
          { 
              quantia = int.Parse(InputQuantidade.Text);
              Escolha = "Dy8rl 8 Relés";
          }

          Dy8RL dy8RL = new Dy8RL(quantia, 1);

          LedVerde3mm = dy8RL.quantiaLeds();
          Resistor1k = dy8RL.quantiaResistores();
          Diodo1n4007 = dy8RL.quantiaDiodos();
          ReleSRD05VDC = dy8RL.quantiaReles();
      }

      private void opcao_Click_1(object sender, RoutedEventArgs e)
      {

      }
    */
}
