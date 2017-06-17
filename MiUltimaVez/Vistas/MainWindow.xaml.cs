using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Biblioteca;

namespace Vistas
{
    
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CollecionPreservativo col = new CollecionPreservativo();

        public MainWindow()
        {
            InitializeComponent();
            CBXMarca.ItemsSource = Enum.GetValues(typeof(Marca));
            CBXPas.ItemsSource = Enum.GetValues(typeof(Marca));
        }

        private void btnAgregarCon_Click(object sender, RoutedEventArgs e)
        {
            Condon cons = new Condon();
            
            cons.Nombre = txtNombreCon.Text;
            cons.Marca = (Marca)CBXMarca.SelectedItem;
            if (CHConsulC.IsChecked == true)
            {
                cons.EsConsultorio = true;
            }
            else
            {
                cons.EsConsultorio = false;
            }
            cons.Cantidad = int.Parse(txtCant.Text);
            cons.Caducidad = (DateTime)DPCadCon.SelectedDate;
            col.Add(cons);

            DTInformacion.ItemsSource=col.ListaCon();
            
        }

        private void btnAgregarPas_Click(object sender, RoutedEventArgs e)
        {
            Pastilla pasti = new Pastilla();
            pasti.Nombre = txtNomPas.Text;
            pasti.Marca = (Marca)CBXPas.SelectedItem;
            if (CHConPas.IsChecked == true)
            {
                pasti.EsConsultorio = true;
            }
            else
            {
                pasti.EsConsultorio = false;
            }
            pasti.Ciclo = int.Parse(txtCiclo.Text);
            pasti.Caducidad = (DateTime)DPCadPas.SelectedDate;
            col.Add(pasti);

            DTInforPas.ItemsSource = col.ListaPas();
            

        }
    }
}
