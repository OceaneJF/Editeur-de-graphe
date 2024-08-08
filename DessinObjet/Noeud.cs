using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DessinObjet
{
    internal class Noeud : ISupprimable
    {
        public Point Position { get; set; }
        public Size Taille { get; set; }
        public int Epaisseur { get; set; } = 2;
        public Color Couleur { get; set; } = Color.Blue;
        public string Texte { get; set; } = "";
        public bool Supprimé { get; set; } = false;


        public void Dessine(Graphics g)
        {
            Rectangle r = new Rectangle(Outils.DessinVersEcran(Position), Outils.DessinVersEcran(Taille));
            Pen p = new Pen(Couleur, Epaisseur);
            g.DrawRectangle(p, r);
            g.DrawString(Texte, new Font("Times New Roman", 15, FontStyle.Regular), Brushes.Black, Outils.DessinVersEcran(Position));
        }

        public Point Centre
        {
            get { return new Point(Position.X + Taille.Width / 2, Position.Y + Taille.Height / 2); }
        }

        public bool Contient(Point p)
        {
            Rectangle r = new Rectangle(Position, Taille);
            return r.Contains(p);
        }

        public void Déplace(Point p)
        {
           /* int x = p.X - Position.X - Outils.Origine.X;
            int y = p.Y - Position.Y - Outils.Origine.Y;
            Point current = Position;
            current.Offset(x, y);
            Position = current;*/
            Position=Outils.EcranVersDessin(p);
        }
    }
}
