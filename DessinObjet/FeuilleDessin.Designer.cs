namespace DessinObjet
{
    partial class FeuilleDessin
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FeuilleDessin));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.déplacement = new System.Windows.Forms.ToolStripButton();
            this.réduire = new System.Windows.Forms.ToolStripButton();
            this.agrandir = new System.Windows.Forms.ToolStripButton();
            this.couleur = new System.Windows.Forms.ToolStripButton();
            this.éffacer = new System.Windows.Forms.ToolStripButton();
            this.VScrollBar = new System.Windows.Forms.VScrollBar();
            this.HScrollBar = new System.Windows.Forms.HScrollBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.editionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AnnulerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RétablirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AnnulerToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.RétablirToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.déplacement,
            this.réduire,
            this.agrandir,
            this.couleur,
            this.éffacer,
            this.AnnulerToolStripButton,
            this.RétablirToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // déplacement
            // 
            this.déplacement.CheckOnClick = true;
            this.déplacement.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.déplacement.Image = ((System.Drawing.Image)(resources.GetObject("déplacement.Image")));
            this.déplacement.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.déplacement.Name = "déplacement";
            this.déplacement.Size = new System.Drawing.Size(23, 22);
            this.déplacement.Text = "déplacer";
            // 
            // réduire
            // 
            this.réduire.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.réduire.Image = ((System.Drawing.Image)(resources.GetObject("réduire.Image")));
            this.réduire.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.réduire.Name = "réduire";
            this.réduire.Size = new System.Drawing.Size(23, 22);
            this.réduire.Text = "-";
            this.réduire.ToolTipText = "réduire les bordures du noeuds";
            this.réduire.Click += new System.EventHandler(this.Réduire_Click);
            // 
            // agrandir
            // 
            this.agrandir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.agrandir.Image = ((System.Drawing.Image)(resources.GetObject("agrandir.Image")));
            this.agrandir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.agrandir.Name = "agrandir";
            this.agrandir.Size = new System.Drawing.Size(23, 22);
            this.agrandir.Text = "+";
            this.agrandir.ToolTipText = "agrandir les bordures du noeud";
            this.agrandir.Click += new System.EventHandler(this.Agrandir_Click);
            // 
            // couleur
            // 
            this.couleur.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.couleur.Image = ((System.Drawing.Image)(resources.GetObject("couleur.Image")));
            this.couleur.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.couleur.Name = "couleur";
            this.couleur.Size = new System.Drawing.Size(23, 22);
            this.couleur.Text = "toolStripButton1";
            this.couleur.Click += new System.EventHandler(this.Couleur_Click);
            // 
            // éffacer
            // 
            this.éffacer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.éffacer.Image = ((System.Drawing.Image)(resources.GetObject("éffacer.Image")));
            this.éffacer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.éffacer.Name = "éffacer";
            this.éffacer.Size = new System.Drawing.Size(47, 22);
            this.éffacer.Text = "éffacer";
            this.éffacer.ToolTipText = "éffacer le dessin";
            this.éffacer.Click += new System.EventHandler(this.Éffacer_Click);
            // 
            // VScrollBar
            // 
            this.VScrollBar.Dock = System.Windows.Forms.DockStyle.Right;
            this.VScrollBar.LargeChange = 50;
            this.VScrollBar.Location = new System.Drawing.Point(783, 49);
            this.VScrollBar.Maximum = 800;
            this.VScrollBar.Name = "VScrollBar";
            this.VScrollBar.Size = new System.Drawing.Size(17, 401);
            this.VScrollBar.SmallChange = 4;
            this.VScrollBar.TabIndex = 1;
            this.VScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.VScrollBar_Scroll);
            // 
            // HScrollBar
            // 
            this.HScrollBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.HScrollBar.LargeChange = 50;
            this.HScrollBar.Location = new System.Drawing.Point(0, 433);
            this.HScrollBar.Maximum = 800;
            this.HScrollBar.Name = "HScrollBar";
            this.HScrollBar.Size = new System.Drawing.Size(783, 17);
            this.HScrollBar.SmallChange = 4;
            this.HScrollBar.TabIndex = 2;
            this.HScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.HScrollBar_Scroll);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // editionToolStripMenuItem
            // 
            this.editionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AnnulerToolStripMenuItem,
            this.RétablirToolStripMenuItem});
            this.editionToolStripMenuItem.Name = "editionToolStripMenuItem";
            this.editionToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.editionToolStripMenuItem.Text = "Edition";
            // 
            // AnnulerToolStripMenuItem
            // 
            this.AnnulerToolStripMenuItem.Name = "AnnulerToolStripMenuItem";
            this.AnnulerToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.AnnulerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.AnnulerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.AnnulerToolStripMenuItem.Text = "Annuler";
            this.AnnulerToolStripMenuItem.Click += new System.EventHandler(this.AnnulerToolStripMenuItem_Click);
            // 
            // RétablirToolStripMenuItem
            // 
            this.RétablirToolStripMenuItem.Name = "RétablirToolStripMenuItem";
            this.RétablirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.RétablirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.RétablirToolStripMenuItem.Text = "Rétablir";
            this.RétablirToolStripMenuItem.Click += new System.EventHandler(this.RétablirToolStripMenuItem_Click);
            // 
            // AnnulerToolStripButton
            // 
            this.AnnulerToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AnnulerToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("AnnulerToolStripButton.Image")));
            this.AnnulerToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AnnulerToolStripButton.Name = "AnnulerToolStripButton";
            this.AnnulerToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.AnnulerToolStripButton.Text = "toolStripButton1";
            this.AnnulerToolStripButton.ToolTipText = "annuler";
            this.AnnulerToolStripButton.Click += new System.EventHandler(this.AnnulerToolStripMenuItem_Click);
            // 
            // RétablirToolStripButton
            // 
            this.RétablirToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RétablirToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("RétablirToolStripButton.Image")));
            this.RétablirToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RétablirToolStripButton.Name = "RétablirToolStripButton";
            this.RétablirToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.RétablirToolStripButton.Text = "toolStripButton1";
            this.RétablirToolStripButton.ToolTipText = "rétablir";
            this.RétablirToolStripButton.Click += new System.EventHandler(this.RétablirToolStripMenuItem_Click);
            // 
            // FeuilleDessin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.HScrollBar);
            this.Controls.Add(this.VScrollBar);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FeuilleDessin";
            this.Text = "Premiers dessins";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FeuilleDessin_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FeuilleDessin_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FeuilleDessin_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FeuilleDessin_MouseUp);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton déplacement;
        private System.Windows.Forms.ToolStripButton réduire;
        private System.Windows.Forms.ToolStripButton agrandir;
        private System.Windows.Forms.ToolStripButton éffacer;
        private System.Windows.Forms.ToolStripButton couleur;
        private System.Windows.Forms.VScrollBar VScrollBar;
        private System.Windows.Forms.HScrollBar HScrollBar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AnnulerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RétablirToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton AnnulerToolStripButton;
        private System.Windows.Forms.ToolStripButton RétablirToolStripButton;
    }
}

