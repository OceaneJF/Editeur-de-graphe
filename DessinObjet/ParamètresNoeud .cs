using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DessinObjet
{
    public partial class ParamètresNoeud : Form
    {
        public Color Couleur { get { return couleur.BackColor; } }
        public int Epaisseur { get { return (int)épaisseur.Value; } }

        public String Texte { get { return texte.Text; } }

        public ParamètresNoeud(Color c, int e,String t)
        {
            InitializeComponent();
            couleur.BackColor = c;
            épaisseur.Value= e;
            texte.Text = t;
        }

        private void Couleur_Click(object sender, EventArgs e)
        {
            ColorDialog c =new ColorDialog {Color = Couleur };
            if(c.ShowDialog() == DialogResult.OK)
            {
                couleur.BackColor=c.Color;

            }
     
        }
    }
}
