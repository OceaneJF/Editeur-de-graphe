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
    public partial class FeuilleDessin : Form
    {
        List<Noeud> noeuds;
        Noeud sélection;
        bool enMouvement;
        List<Trait> traits;
        Trait traitCourant = null;
        bool enDessinTrait;
        Graphics g;
        Stack<Action> actionsEffectuées = new Stack<Action>(50);
        Stack<Action> actionsAnnulées = new Stack<Action>(50);
        public FeuilleDessin()
        {
            InitializeComponent();
            noeuds = new List<Noeud>();
            traits = new List<Trait>();
            enDessinTrait = false;
            MouseWheel += FeuilleDessin_MouseWheel;

        }

        private void FeuilleDessin_Paint(object sender, PaintEventArgs e)
        {
            foreach (Noeud n in noeuds)
            {
                if (!n.Supprimé)
                {
                    n.Dessine(e.Graphics);
                }
            }

            foreach (Trait t in traits)
            {
                if (!t.Supprimé)
                {
                    t.Dessine(e.Graphics);
                }
            }

            if (traitCourant != null)
            {
                traitCourant.DessineCurrent(e.Graphics);
            }

           /* ContextMenuStrip cm =new ContextMenuStrip();
            foreach (string libel in new string[] {"Supprimer","Modifier"})
            {
                ToolStripMenuItem élément = new ToolStripMenuItem(libel);
                élément.Click += new EventHandler(Elément_Click);
                cm.Items.Add(élément);
            }
            cm.Show(this, e.Location);*/
        }
        /*private void Elément_Click*/
        private void FeuilleDessin_MouseDown(object sender, MouseEventArgs e)
        {
            sélection = Sélection(e.Location);
            if (déplacement.Checked)
            {
                enMouvement = sélection != null;
            }
            else
            {
                if (e.Button == MouseButtons.Left)
                {
                    if (sélection == null)
                    {
                        Noeud noeud = new Noeud
                        {
                            Position = Outils.EcranVersDessin(e.Location),
                            Taille = new Size(20, 20),
                            Epaisseur = Outils.EpaisseurParDéfaut,
                            Couleur = Outils.CouleurParDéfaut,
                            Texte = Outils.TexteParDéfaut

                        };
                        noeuds.Add(noeud);
                        Action a = new Action
                        {
                            TypeAction = Type_Action.Creer,
                            Objet = noeud,
                        };
                        actionsEffectuées.Push(a);
                        Refresh();
                    }
                    else
                    {
                        enDessinTrait = true;
                    }
                }
                else
                {
                    if (sélection != null)
                    {
                        ParamètresNoeud param = new ParamètresNoeud(sélection.Couleur, sélection.Epaisseur, sélection.Texte);
                        if (param.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {
                            sélection.Couleur = param.Couleur;
                            sélection.Epaisseur = param.Epaisseur;
                            sélection.Texte = param.Texte;
                            Refresh();
                        }
                    }
                }
            }
        }
        private Noeud Sélection(Point p)
        {
            Noeud res = null;
            int i = 0;
            while (res == null && i < noeuds.Count)
            {
                if (noeuds[i].Contient(Outils.EcranVersDessin(p)) && !noeuds[i].Supprimé)
                {
                    res = noeuds[i];
                }
                i++;
            }
            return res;
        }

        private void FeuilleDessin_MouseMove(object sender, MouseEventArgs e)
        {
            if (enMouvement)
            {
                sélection.Déplace(e.Location);
                Refresh();

            }
            else
            {
                if (sélection != null && enDessinTrait)
                {

                    Trait t = new Trait
                    {
                        Source= sélection,
                        current = e.Location
                    };
                    traitCourant = t;
                    Refresh();
                }

            }
        }

        private void FeuilleDessin_MouseUp(object sender, MouseEventArgs e)
        {
            enMouvement = false;
            traitCourant = null;
            if (enDessinTrait)
            {
                Noeud fin = Sélection(e.Location);
                if (fin != null && !fin.Equals(sélection))
                {
                    Trait trait = new Trait
                    {
                        Source = sélection,
                        Destination = fin
                    };
                    traits.Add(trait);
                    Action a = new Action
                    {
                        TypeAction = Type_Action.Creer,
                        Objet = trait,
                    };
                    actionsEffectuées.Push(a);
                }
                enDessinTrait = false;
                Refresh();
            }
        }

        private void Réduire_Click(object sender, EventArgs e)
        {
            Outils.EpaisseurParDéfaut--;
        }

        private void Agrandir_Click(object sender, EventArgs e)
        {
            Outils.EpaisseurParDéfaut++;
        }

        private void Éffacer_Click(object sender, EventArgs e)
        {
            foreach (var noeud in noeuds)
            {
                noeud.Supprimé = true;
                Action a = new Action
                {
                    TypeAction = Type_Action.Detruire,
                    Objet = noeud,
                };
                actionsEffectuées.Push(a);
            }
            foreach (var trait in traits)
            {
                trait.Supprimé = true;
                Action a = new Action
                {
                    TypeAction = Type_Action.Detruire,
                    Objet = trait,
                };
                actionsEffectuées.Push(a);
            }
            /*traits.Clear();
            noeuds.Clear();*/
            Refresh();

        }

        private void Couleur_Click(object sender, EventArgs e)
        {
            ColorDialog col = new ColorDialog { Color = Outils.CouleurParDéfaut };
            if (col.ShowDialog() == DialogResult.OK)
            {
                Outils.CouleurParDéfaut = col.Color;
            }
        }

        private void VScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            Outils.Origine = new Point(Outils.Origine.X, -e.NewValue);
            Refresh();
        }

        private void HScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            Outils.Origine = new Point(-e.NewValue, Outils.Origine.Y);
            Refresh();
        }

        private void FeuilleDessin_MouseWheel(object sender, MouseEventArgs e)
        {
            if (Control.ModifierKeys == Keys.Control)
            {
                if (e.Delta > 0)
                {
                    Outils.Zoom *= 1.1f;
                    if (Outils.Zoom > 15f)
                        Outils.Zoom = 15f;
                }
                if (e.Delta < 0)
                {
                    Outils.Zoom /= 1.1f;
                    if (Outils.Zoom < 0.1f)
                        Outils.Zoom = 0.1f;

                }
            }
            Refresh();
        }

        private void AnnulerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (actionsEffectuées.Count > 0)
            {
                Action a = actionsEffectuées.Pop();
                a.Undo();
                actionsAnnulées.Push(a);
                Refresh();
            }
        }

        private void RétablirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (actionsAnnulées.Count > 0)
            {
                Action a = actionsAnnulées.Pop();
                actionsEffectuées.Push(a);
                a.Redo();
                Refresh();
            }
        }



    }
}
