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
using Solucion.Modelo;
using Solucion.Datos;

namespace Solucion.Presentacion
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            cbxSexo.ItemsSource = Enum.GetValues(typeof(Sexo));
            cbxEstadoCivil.ItemsSource = Enum.GetValues(typeof(EstadoCivil));
            lstbxPersonas.ItemsSource = ColeccionPersona.lstPersona;
        }

        private void btnAgregar_Click(object sender, RoutedEventArgs e)
        {
            Persona p = new Persona();
            p.Nombre = txtNombre.Text;
            p.Rut = int.Parse(txtRut.Text);
            p.DV = txtDV.Text;
            p.EstCivil = (EstadoCivil) cbxEstadoCivil.SelectedValue;
            p.Sex = (Sexo) cbxSexo.SelectedValue;

            ColeccionPersona.lstPersona.Add(p);

            lstbxPersonas.ItemsSource = null;
            lstbxPersonas.ItemsSource = ColeccionPersona.lstPersona;
        }
    }
}
