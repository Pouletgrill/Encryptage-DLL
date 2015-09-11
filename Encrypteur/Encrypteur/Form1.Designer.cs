namespace Encrypteur
{
    partial class Form1
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
            this.GB_Rbutton = new System.Windows.Forms.GroupBox();
            this.NUD_Circulaire = new System.Windows.Forms.NumericUpDown();
            this.NUD_Rotation = new System.Windows.Forms.NumericUpDown();
            this.RB_Perso = new System.Windows.Forms.RadioButton();
            this.RB_Circulaire = new System.Windows.Forms.RadioButton();
            this.RB_Rotation = new System.Windows.Forms.RadioButton();
            this.TB_Text = new System.Windows.Forms.TextBox();
            this.BTN_Save = new System.Windows.Forms.Button();
            this.BTN_Load = new System.Windows.Forms.Button();
            this.BTN_Encrypter = new System.Windows.Forms.Button();
            this.BTN_Decrypter = new System.Windows.Forms.Button();
            this.GB_Rbutton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Circulaire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Rotation)).BeginInit();
            this.SuspendLayout();
            // 
            // GB_Rbutton
            // 
            this.GB_Rbutton.Controls.Add(this.NUD_Circulaire);
            this.GB_Rbutton.Controls.Add(this.NUD_Rotation);
            this.GB_Rbutton.Controls.Add(this.RB_Perso);
            this.GB_Rbutton.Controls.Add(this.RB_Circulaire);
            this.GB_Rbutton.Controls.Add(this.RB_Rotation);
            this.GB_Rbutton.Location = new System.Drawing.Point(12, 41);
            this.GB_Rbutton.Name = "GB_Rbutton";
            this.GB_Rbutton.Size = new System.Drawing.Size(145, 100);
            this.GB_Rbutton.TabIndex = 0;
            this.GB_Rbutton.TabStop = false;
            this.GB_Rbutton.Text = "Type Encryption";
            // 
            // NUD_Circulaire
            // 
            this.NUD_Circulaire.Enabled = false;
            this.NUD_Circulaire.Location = new System.Drawing.Point(81, 43);
            this.NUD_Circulaire.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NUD_Circulaire.Name = "NUD_Circulaire";
            this.NUD_Circulaire.Size = new System.Drawing.Size(33, 20);
            this.NUD_Circulaire.TabIndex = 4;
            // 
            // NUD_Rotation
            // 
            this.NUD_Rotation.Location = new System.Drawing.Point(81, 20);
            this.NUD_Rotation.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NUD_Rotation.Name = "NUD_Rotation";
            this.NUD_Rotation.Size = new System.Drawing.Size(33, 20);
            this.NUD_Rotation.TabIndex = 3;
            // 
            // RB_Perso
            // 
            this.RB_Perso.AutoSize = true;
            this.RB_Perso.Location = new System.Drawing.Point(7, 66);
            this.RB_Perso.Name = "RB_Perso";
            this.RB_Perso.Size = new System.Drawing.Size(52, 17);
            this.RB_Perso.TabIndex = 2;
            this.RB_Perso.Text = "Perso";
            this.RB_Perso.UseVisualStyleBackColor = true;
            this.RB_Perso.Click += new System.EventHandler(this.RB_All_Click);
            // 
            // RB_Circulaire
            // 
            this.RB_Circulaire.AutoSize = true;
            this.RB_Circulaire.Location = new System.Drawing.Point(7, 43);
            this.RB_Circulaire.Name = "RB_Circulaire";
            this.RB_Circulaire.Size = new System.Drawing.Size(68, 17);
            this.RB_Circulaire.TabIndex = 1;
            this.RB_Circulaire.Text = "Circulaire";
            this.RB_Circulaire.UseVisualStyleBackColor = true;
            this.RB_Circulaire.Click += new System.EventHandler(this.RB_All_Click);
            // 
            // RB_Rotation
            // 
            this.RB_Rotation.AutoSize = true;
            this.RB_Rotation.Checked = true;
            this.RB_Rotation.Location = new System.Drawing.Point(7, 20);
            this.RB_Rotation.Name = "RB_Rotation";
            this.RB_Rotation.Size = new System.Drawing.Size(65, 17);
            this.RB_Rotation.TabIndex = 0;
            this.RB_Rotation.TabStop = true;
            this.RB_Rotation.Text = "Rotation";
            this.RB_Rotation.UseVisualStyleBackColor = true;
            this.RB_Rotation.Click += new System.EventHandler(this.RB_All_Click);
            // 
            // TB_Text
            // 
            this.TB_Text.Location = new System.Drawing.Point(163, 41);
            this.TB_Text.Multiline = true;
            this.TB_Text.Name = "TB_Text";
            this.TB_Text.Size = new System.Drawing.Size(227, 100);
            this.TB_Text.TabIndex = 1;
            this.TB_Text.TextChanged += new System.EventHandler(this.TB_Text_TextChanged);
            // 
            // BTN_Save
            // 
            this.BTN_Save.Location = new System.Drawing.Point(93, 12);
            this.BTN_Save.Name = "BTN_Save";
            this.BTN_Save.Size = new System.Drawing.Size(75, 23);
            this.BTN_Save.TabIndex = 2;
            this.BTN_Save.Text = "Sauvegarder";
            this.BTN_Save.UseVisualStyleBackColor = true;
            // 
            // BTN_Load
            // 
            this.BTN_Load.Location = new System.Drawing.Point(12, 12);
            this.BTN_Load.Name = "BTN_Load";
            this.BTN_Load.Size = new System.Drawing.Size(75, 23);
            this.BTN_Load.TabIndex = 3;
            this.BTN_Load.Text = "Importer";
            this.BTN_Load.UseVisualStyleBackColor = true;
            // 
            // BTN_Encrypter
            // 
            this.BTN_Encrypter.Location = new System.Drawing.Point(9, 147);
            this.BTN_Encrypter.Name = "BTN_Encrypter";
            this.BTN_Encrypter.Size = new System.Drawing.Size(75, 23);
            this.BTN_Encrypter.TabIndex = 4;
            this.BTN_Encrypter.Text = "Encrypter";
            this.BTN_Encrypter.UseVisualStyleBackColor = true;
            this.BTN_Encrypter.Click += new System.EventHandler(this.BTN_Encrypter_Click);
            // 
            // BTN_Decrypter
            // 
            this.BTN_Decrypter.Location = new System.Drawing.Point(90, 146);
            this.BTN_Decrypter.Name = "BTN_Decrypter";
            this.BTN_Decrypter.Size = new System.Drawing.Size(75, 23);
            this.BTN_Decrypter.TabIndex = 5;
            this.BTN_Decrypter.Text = "Decrypter";
            this.BTN_Decrypter.UseVisualStyleBackColor = true;
            this.BTN_Decrypter.Click += new System.EventHandler(this.BTN_Decrypter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 263);
            this.Controls.Add(this.BTN_Decrypter);
            this.Controls.Add(this.BTN_Encrypter);
            this.Controls.Add(this.BTN_Load);
            this.Controls.Add(this.BTN_Save);
            this.Controls.Add(this.TB_Text);
            this.Controls.Add(this.GB_Rbutton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.GB_Rbutton.ResumeLayout(false);
            this.GB_Rbutton.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Circulaire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Rotation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GB_Rbutton;
        private System.Windows.Forms.RadioButton RB_Perso;
        private System.Windows.Forms.RadioButton RB_Circulaire;
        private System.Windows.Forms.RadioButton RB_Rotation;
        private System.Windows.Forms.NumericUpDown NUD_Rotation;
        private System.Windows.Forms.TextBox TB_Text;
        private System.Windows.Forms.Button BTN_Save;
        private System.Windows.Forms.Button BTN_Load;
        private System.Windows.Forms.NumericUpDown NUD_Circulaire;
        private System.Windows.Forms.Button BTN_Encrypter;
        private System.Windows.Forms.Button BTN_Decrypter;
    }
}

