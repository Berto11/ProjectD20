using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DatosPJ;

namespace ProjectD20_2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void añadirPJ_Click(object sender, EventArgs e)
        {
            PJ personaje = new PJ();
            personaje.Parent = panelPJ;
            //personaje.Anchor = AnchorStyles.Left;
            //personaje.Dock = DockStyle.Left;
            //personaje.Anchor = AnchorStyles.Top;
            //personaje.Anchor = AnchorStyles.Bottom;
            //personaje.AutoSize = true;
            //personaje.Height = 254;


            //MessageBox.Show(personaje.Width + ", " + personaje.Height);
            
            // personaje.Width = panelPJ.Width % 3;
                    
        }

        private void panelPJ_ControlAdded(object sender, ControlEventArgs e)
        {
            //Ajustamos las 3 columnas de Fichas de PJ
            switch ((panelPJ.Controls.Count -1) % 3)
            {
                case 0:
                    e.Control.Left = 0;
                    break;
                case 1:
                    e.Control.Left = e.Control.Left + 350;
                    break;
                case 2:
                    e.Control.Left = e.Control.Left + 700;
                    break;
            }
            //Ajustamos las filas de Fichas de PJ
            e.Control.Top = e.Control.Top + ((panelPJ.Controls.Count-1) / 3 * 251);
        }
    }
}
