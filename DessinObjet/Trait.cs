using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DessinObjet
{
    internal class Trait : ISupprimable
    {
        public Noeud Source { get; set; }
        public Noeud Destination { get; set; }
        public Point current { get; set; }
        public bool Supprimé { get; set; } = false;
        public void Dessine(Graphics g)
        {
            g.DrawLine(Pens.Black, Outils.DessinVersEcran(Source.Centre), Outils.DessinVersEcran(Destination.Centre));
        }

        public void DessineCurrent(Graphics g)
        {
            g.DrawLine(Pens.LightGray, Outils.DessinVersEcran(Source.Centre), current);
        }
    }
}
