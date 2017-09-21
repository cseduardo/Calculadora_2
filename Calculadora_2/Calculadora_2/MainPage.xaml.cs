using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Calculadora_2
{
    public partial class MainPage : ContentPage
    {
        public static Int32 dato1 = new Int32();
        public static Int32 dato2 = new Int32();
        public MainPage()
        {
            InitializeComponent();
        }

        private void porciento_Clicked(object sender, EventArgs e)
        {
            mostrar.Text = mostrar.Text + "%";
        }

        private void raiz_Clicked(object sender, EventArgs e)
        {
            mostrar.Text = mostrar.Text + "√";
        }

        private void cuadrado_Clicked(object sender, EventArgs e)
        {
            mostrar.Text = mostrar.Text + "^2";
        }

        private void inversa_Clicked(object sender, EventArgs e)
        {
            mostrar.Text = mostrar.Text + "1/";
        }

        private void borrar_todo_Clicked(object sender, EventArgs e)
        {
            mostrar.Text = mostrar.Text + "";
        }

        private void borrar_ultimo_Clicked(object sender, EventArgs e)
        {
            mostrar.Text = mostrar.Text + "";
        }

        private void borrar_Clicked(object sender, EventArgs e)
        {
            mostrar.Text = mostrar.Text + "";
        }

        private void dividir_Clicked(object sender, EventArgs e)
        {
            mostrar.Text = mostrar.Text + "÷";
        }

        private void siete_Clicked(object sender, EventArgs e)
        {
            mostrar.Text = mostrar.Text + "7";
        }

        private void ocho_Clicked(object sender, EventArgs e)
        {
            mostrar.Text = mostrar.Text + "8";
        }

        private void nueve_Clicked(object sender, EventArgs e)
        {
            mostrar.Text = mostrar.Text + "9";
        }

        private void mult_Clicked(object sender, EventArgs e)
        {
            mostrar.Text = mostrar.Text + "*";
        }

        private void cuatro_Clicked(object sender, EventArgs e)
        {
            mostrar.Text = mostrar.Text + "4";
        }

        private void cinco_Clicked(object sender, EventArgs e)
        {
            mostrar.Text = mostrar.Text + "5";
        }

        private void seis_Clicked(object sender, EventArgs e)
        {
            mostrar.Text = mostrar.Text + "6";
        }

        private void menos_Clicked(object sender, EventArgs e)
        {
            mostrar.Text = mostrar.Text + "-";
        }

        private void uno_Clicked(object sender, EventArgs e)
        {
            mostrar.Text = mostrar.Text + "1";
        }

        private void dos_Clicked(object sender, EventArgs e)
        {
            mostrar.Text = mostrar.Text + "2";
        }

        private void tres_Clicked(object sender, EventArgs e)
        {
            mostrar.Text = mostrar.Text + "3";
        }

        private void suma_Clicked(object sender, EventArgs e)
        {
            mostrar.Text = mostrar.Text + "+";
        }

        private void absoluto_Clicked(object sender, EventArgs e)
        {
            mostrar.Text = mostrar.Text + "";
        }

        private void cero_Clicked(object sender, EventArgs e)
        {
            mostrar.Text = mostrar.Text + "0";
        }

        private void punto_Clicked(object sender, EventArgs e)
        {
            if (!mostrar.Text.Contains("."))
            {
                mostrar.Text = mostrar.Text += ".";
            }
        }

        private void igual_Clicked(object sender, EventArgs e)
        {
            mostrar.Text = mostrar.Text + "";
        }
    }
}
