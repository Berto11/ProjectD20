using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Control_Usuario
{
    public partial class DatosPJ : UserControl
    {
        public DatosPJ()
        {
            InitializeComponent();
        }

        private void tiradaD20_Click(object sender, EventArgs e)
        {
            //Convertimos el valor de los TextBox en numero
            int Avistar = Convert.ToInt32(tbAvistar.Text);
            int Buscar = Convert.ToInt32(tbBuscar.Text);
            int Escuchar = Convert.ToInt32(tbEscuchar.Text);
            int Fort = Convert.ToInt32(tbFort.Text);
            int Ref = Convert.ToInt32(tbRef.Text);
            int Vol = Convert.ToInt32(tbVol.Text);

            //Generamos numero aleatorio entre 1 y 20
            Random rnd = new Random();
            int d20 = rnd.Next(1, 20);

            //Realizamos la suma
            int resultadoAvistar = Avistar + d20;
            int resultadoBuscar = Buscar + d20;
            int resultadoEscuchar = Escuchar + d20;
            int resultadoFort = Fort + d20;
            int resultadoRef = Ref + d20;
            int resultadoVol = Vol + d20;

            //Mostramos el resultado
            rdoAvistar.Text = resultadoAvistar.ToString();
            rdoBuscar.Text = resultadoBuscar.ToString();
            rdoEscuchar.Text = resultadoEscuchar.ToString();
            rdoFort.Text = resultadoFort.ToString();
            rdoRef.Text = resultadoRef.ToString();
            rdoVol.Text = resultadoVol.ToString();
        }
    }
}
