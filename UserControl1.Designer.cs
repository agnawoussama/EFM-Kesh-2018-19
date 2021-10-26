
namespace EFM_Kesh_2018_19
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvAutocar = new System.Windows.Forms.DataGridView();
            this.btnAjt = new System.Windows.Forms.Button();
            this.btnSupp = new System.Windows.Forms.Button();
            this.btnMod = new System.Windows.Forms.Button();
            this.btnSauv = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNxt = new System.Windows.Forms.Button();
            this.btnPrvs = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbx_Mrque = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbx_codeCar = new System.Windows.Forms.TextBox();
            this.dtmpck_dtAchat = new System.Windows.Forms.DateTimePicker();
            this.txtbx_cnsom = new System.Windows.Forms.TextBox();
            this.txtbx_Cpcit = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutocar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAutocar
            // 
            this.dgvAutocar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAutocar.Location = new System.Drawing.Point(14, 96);
            this.dgvAutocar.MultiSelect = false;
            this.dgvAutocar.Name = "dgvAutocar";
            this.dgvAutocar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAutocar.Size = new System.Drawing.Size(717, 260);
            this.dgvAutocar.TabIndex = 0;
            // 
            // btnAjt
            // 
            this.btnAjt.BackColor = System.Drawing.Color.CadetBlue;
            this.btnAjt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjt.Location = new System.Drawing.Point(14, 362);
            this.btnAjt.Name = "btnAjt";
            this.btnAjt.Size = new System.Drawing.Size(141, 47);
            this.btnAjt.TabIndex = 5;
            this.btnAjt.Text = "Ajouter";
            this.btnAjt.UseVisualStyleBackColor = false;
            this.btnAjt.Click += new System.EventHandler(this.btnAjt_Click);
            // 
            // btnSupp
            // 
            this.btnSupp.BackColor = System.Drawing.Color.CadetBlue;
            this.btnSupp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupp.Location = new System.Drawing.Point(392, 362);
            this.btnSupp.Name = "btnSupp";
            this.btnSupp.Size = new System.Drawing.Size(141, 47);
            this.btnSupp.TabIndex = 6;
            this.btnSupp.Text = "Supprimer";
            this.btnSupp.UseVisualStyleBackColor = false;
            this.btnSupp.Click += new System.EventHandler(this.btnSupp_Click);
            // 
            // btnMod
            // 
            this.btnMod.BackColor = System.Drawing.Color.CadetBlue;
            this.btnMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMod.Location = new System.Drawing.Point(199, 362);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(141, 47);
            this.btnMod.TabIndex = 7;
            this.btnMod.Text = "Modifier";
            this.btnMod.UseVisualStyleBackColor = false;
            this.btnMod.Click += new System.EventHandler(this.btnMod_Click);
            // 
            // btnSauv
            // 
            this.btnSauv.BackColor = System.Drawing.Color.CadetBlue;
            this.btnSauv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSauv.Location = new System.Drawing.Point(590, 362);
            this.btnSauv.Name = "btnSauv";
            this.btnSauv.Size = new System.Drawing.Size(141, 47);
            this.btnSauv.TabIndex = 8;
            this.btnSauv.Text = "Sauvegarder";
            this.btnSauv.UseVisualStyleBackColor = false;
            // 
            // btnLast
            // 
            this.btnLast.BackColor = System.Drawing.SystemColors.Window;
            this.btnLast.BackgroundImage = global::EFM_Kesh_2018_19.Properties.Resources.down_all;
            this.btnLast.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLast.FlatAppearance.BorderSize = 0;
            this.btnLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLast.ForeColor = System.Drawing.SystemColors.Window;
            this.btnLast.Location = new System.Drawing.Point(746, 315);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(42, 41);
            this.btnLast.TabIndex = 4;
            this.btnLast.UseVisualStyleBackColor = false;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnNxt
            // 
            this.btnNxt.BackColor = System.Drawing.SystemColors.Window;
            this.btnNxt.BackgroundImage = global::EFM_Kesh_2018_19.Properties.Resources.down_one;
            this.btnNxt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNxt.FlatAppearance.BorderSize = 0;
            this.btnNxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNxt.ForeColor = System.Drawing.SystemColors.Window;
            this.btnNxt.Location = new System.Drawing.Point(746, 238);
            this.btnNxt.Name = "btnNxt";
            this.btnNxt.Size = new System.Drawing.Size(42, 41);
            this.btnNxt.TabIndex = 3;
            this.btnNxt.UseVisualStyleBackColor = false;
            this.btnNxt.Click += new System.EventHandler(this.btnNxt_Click);
            // 
            // btnPrvs
            // 
            this.btnPrvs.BackColor = System.Drawing.SystemColors.Window;
            this.btnPrvs.BackgroundImage = global::EFM_Kesh_2018_19.Properties.Resources.up_one;
            this.btnPrvs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrvs.FlatAppearance.BorderSize = 0;
            this.btnPrvs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrvs.ForeColor = System.Drawing.SystemColors.Window;
            this.btnPrvs.Location = new System.Drawing.Point(746, 167);
            this.btnPrvs.Name = "btnPrvs";
            this.btnPrvs.Size = new System.Drawing.Size(42, 41);
            this.btnPrvs.TabIndex = 2;
            this.btnPrvs.UseVisualStyleBackColor = false;
            this.btnPrvs.Click += new System.EventHandler(this.btnPrvs_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnFirst.BackgroundImage = global::EFM_Kesh_2018_19.Properties.Resources.up_all;
            this.btnFirst.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFirst.FlatAppearance.BorderSize = 0;
            this.btnFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirst.ForeColor = System.Drawing.SystemColors.Window;
            this.btnFirst.Location = new System.Drawing.Point(746, 96);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(42, 41);
            this.btnFirst.TabIndex = 1;
            this.btnFirst.UseVisualStyleBackColor = false;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Code Car:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(270, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "Capacite:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(525, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "Date Achat:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 18);
            this.label5.TabIndex = 14;
            this.label5.Text = "Consommation:";
            // 
            // cmbx_Mrque
            // 
            this.cmbx_Mrque.FormattingEnabled = true;
            this.cmbx_Mrque.Location = new System.Drawing.Point(346, 56);
            this.cmbx_Mrque.Name = "cmbx_Mrque";
            this.cmbx_Mrque.Size = new System.Drawing.Size(167, 21);
            this.cmbx_Mrque.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(270, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 15;
            this.label1.Text = "Marque:";
            // 
            // txtbx_codeCar
            // 
            this.txtbx_codeCar.Location = new System.Drawing.Point(96, 20);
            this.txtbx_codeCar.Name = "txtbx_codeCar";
            this.txtbx_codeCar.Size = new System.Drawing.Size(166, 20);
            this.txtbx_codeCar.TabIndex = 17;
            // 
            // dtmpck_dtAchat
            // 
            this.dtmpck_dtAchat.CustomFormat = "yyyy-MM-dd";
            this.dtmpck_dtAchat.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtmpck_dtAchat.Location = new System.Drawing.Point(615, 22);
            this.dtmpck_dtAchat.Name = "dtmpck_dtAchat";
            this.dtmpck_dtAchat.Size = new System.Drawing.Size(116, 20);
            this.dtmpck_dtAchat.TabIndex = 18;
            // 
            // txtbx_cnsom
            // 
            this.txtbx_cnsom.Location = new System.Drawing.Point(127, 57);
            this.txtbx_cnsom.Name = "txtbx_cnsom";
            this.txtbx_cnsom.Size = new System.Drawing.Size(135, 20);
            this.txtbx_cnsom.TabIndex = 19;
            // 
            // txtbx_Cpcit
            // 
            this.txtbx_Cpcit.Location = new System.Drawing.Point(346, 20);
            this.txtbx_Cpcit.Name = "txtbx_Cpcit";
            this.txtbx_Cpcit.Size = new System.Drawing.Size(167, 20);
            this.txtbx_Cpcit.TabIndex = 20;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.txtbx_Cpcit);
            this.Controls.Add(this.txtbx_cnsom);
            this.Controls.Add(this.dtmpck_dtAchat);
            this.Controls.Add(this.txtbx_codeCar);
            this.Controls.Add(this.cmbx_Mrque);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSauv);
            this.Controls.Add(this.btnMod);
            this.Controls.Add(this.btnSupp);
            this.Controls.Add(this.btnAjt);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnNxt);
            this.Controls.Add(this.btnPrvs);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.dgvAutocar);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(800, 422);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutocar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAutocar;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPrvs;
        private System.Windows.Forms.Button btnNxt;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnAjt;
        private System.Windows.Forms.Button btnSupp;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.Button btnSauv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbx_Mrque;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbx_codeCar;
        private System.Windows.Forms.DateTimePicker dtmpck_dtAchat;
        private System.Windows.Forms.TextBox txtbx_cnsom;
        private System.Windows.Forms.TextBox txtbx_Cpcit;
    }
}
