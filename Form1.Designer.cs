
namespace EFM_Kesh_2018_19
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.miseAJourDesAutocarsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDesLignesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.voyagesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miseAJourDesAutocarsToolStripMenuItem1,
            this.listeDesLignesToolStripMenuItem1,
            this.voyagesToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 2, 0, 2);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // miseAJourDesAutocarsToolStripMenuItem1
            // 
            this.miseAJourDesAutocarsToolStripMenuItem1.BackColor = System.Drawing.Color.IndianRed;
            this.miseAJourDesAutocarsToolStripMenuItem1.Name = "miseAJourDesAutocarsToolStripMenuItem1";
            this.miseAJourDesAutocarsToolStripMenuItem1.Size = new System.Drawing.Size(181, 24);
            this.miseAJourDesAutocarsToolStripMenuItem1.Text = "Mise a jour des autocars";
            this.miseAJourDesAutocarsToolStripMenuItem1.Click += new System.EventHandler(this.miseAJourDesAutocarsToolStripMenuItem1_Click);
            // 
            // listeDesLignesToolStripMenuItem1
            // 
            this.listeDesLignesToolStripMenuItem1.BackColor = System.Drawing.Color.Moccasin;
            this.listeDesLignesToolStripMenuItem1.Name = "listeDesLignesToolStripMenuItem1";
            this.listeDesLignesToolStripMenuItem1.Size = new System.Drawing.Size(121, 24);
            this.listeDesLignesToolStripMenuItem1.Text = "Liste des lignes";
            this.listeDesLignesToolStripMenuItem1.Click += new System.EventHandler(this.listeDesLignesToolStripMenuItem1_Click);
            // 
            // voyagesToolStripMenuItem1
            // 
            this.voyagesToolStripMenuItem1.BackColor = System.Drawing.Color.LightGreen;
            this.voyagesToolStripMenuItem1.Name = "voyagesToolStripMenuItem1";
            this.voyagesToolStripMenuItem1.Size = new System.Drawing.Size(76, 24);
            this.voyagesToolStripMenuItem1.Text = "Voyages";
            this.voyagesToolStripMenuItem1.Click += new System.EventHandler(this.voyagesToolStripMenuItem1_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 422);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem miseAJourDesAutocarsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listeDesLignesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem voyagesToolStripMenuItem1;
        private System.Windows.Forms.Panel panel1;
    }
}

