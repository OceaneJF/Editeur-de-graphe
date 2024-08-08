using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace DessinObjet
{
    internal class Outils
    {
        public static int EpaisseurParDéfaut =2;
        public static Color CouleurParDéfaut= Color.Blue;
        public static String TexteParDéfaut= String.Empty;
        public static Point Origine { get; set; } = new Point(0, 0);
        public static float Zoom = 1f;

        public static Point DessinVersEcran(Point p) 
        {
            return new Point((int)(p.X*Zoom) + Origine.X, (int)(p.Y * Zoom) + Origine.Y);
        }
        /*public static Point DessinVersEcran(Point p)
        {
            return new Point(p.X + Origine.X, p.Y + Origine.Y);
        }*/

        public static Point EcranVersDessin(Point p)
        {
            return new Point((int)(p.X / Zoom) - Origine.X, (int)(p.Y / Zoom) - Origine.Y);
        }
        /*public static Point EcranVersDessin(Point p)
        {
            return new Point(p.X - Origine.X, p.Y - Origine.Y);
        }*/
        public static Size DessinVersEcran(Size t)
        {
            return new Size((int)(t.Width * Zoom), (int)(t.Height * Zoom));
        }
    }
}
