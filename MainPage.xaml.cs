using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace examenDAPP_OCME
{
    public partial class MainPage : ContentPage
    {
      

        public MainPage()
        {
            InitializeComponent();
        }
        public void Sumar(object sender, EventArgs e)
        {
            // Obtener los valores
            int N1 = int.Parse(Numero1.Text);
            int N2 = int.Parse(Numero2.Text);         
           
            int Suma = N1 + N2;

            //Mostrar el resultado en la etiqueta
            R.Text = $"Resultado: {Suma}";
        }
        public void Restar(object sender, EventArgs e)
        {
            // Obtener los valores
            int N1 = int.Parse(Numero1.Text);
            int N2 = int.Parse(Numero2.Text);

            int resta = N1 - N2;

            R.Text = $"Resultado: {resta}";
        }
        public void Dividir(object sender, EventArgs e)
        {
            // Obtener los valores
            int N1 = int.Parse(Numero1.Text);
            int N2 = int.Parse(Numero2.Text);

            int division = N1 / N2;

            //Mostrar el resultado en la etiqueta
            R.Text = $"Resultado: {division}";
        }
        public void Multiplicar(object sender, EventArgs e)
        {
            // Obtener los valores
            int N1 = int.Parse(Numero1.Text);
            int N2 = int.Parse(Numero2.Text);

            int multiplicacion = N2 * N2;

            //Mostrar el resultado en la etiqueta
            R.Text = $"Resultado: {multiplicacion}";
        }
    }
}
