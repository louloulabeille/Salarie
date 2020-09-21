namespace WindowsFormsSalarie
{
    partial class FormBoutonRadio
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkedListBoxChoix = new System.Windows.Forms.CheckedListBox();
            this.textBoxSaisie = new System.Windows.Forms.TextBox();
            this.labelAffichage = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioFondBlue = new System.Windows.Forms.RadioButton();
            this.radioFondGreen = new System.Windows.Forms.RadioButton();
            this.radioFondRed = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioCaractBlue = new System.Windows.Forms.RadioButton();
            this.radioCaractGreen = new System.Windows.Forms.RadioButton();
            this.radioCaractRed = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radioCasseMajuscule = new System.Windows.Forms.RadioButton();
            this.radioCasseMinuscule = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tapez votre texte";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkedListBoxChoix);
            this.groupBox1.Location = new System.Drawing.Point(532, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 119);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choix";
            // 
            // checkedListBoxChoix
            // 
            this.checkedListBoxChoix.BackColor = System.Drawing.SystemColors.Menu;
            this.checkedListBoxChoix.Enabled = false;
            this.checkedListBoxChoix.FormattingEnabled = true;
            this.checkedListBoxChoix.Items.AddRange(new object[] {
            "Couleur du fond",
            "Couleur des caractères",
            "Casse"});
            this.checkedListBoxChoix.Location = new System.Drawing.Point(21, 22);
            this.checkedListBoxChoix.Name = "checkedListBoxChoix";
            this.checkedListBoxChoix.Size = new System.Drawing.Size(194, 76);
            this.checkedListBoxChoix.TabIndex = 0;
            // 
            // textBoxSaisie
            // 
            this.textBoxSaisie.Location = new System.Drawing.Point(13, 35);
            this.textBoxSaisie.Name = "textBoxSaisie";
            this.textBoxSaisie.Size = new System.Drawing.Size(442, 23);
            this.textBoxSaisie.TabIndex = 3;
            this.textBoxSaisie.TextChanged += new System.EventHandler(this.EventEcriture);
            // 
            // labelAffichage
            // 
            this.labelAffichage.AutoSize = true;
            this.labelAffichage.Location = new System.Drawing.Point(13, 83);
            this.labelAffichage.Name = "labelAffichage";
            this.labelAffichage.Size = new System.Drawing.Size(0, 15);
            this.labelAffichage.TabIndex = 4;
            this.labelAffichage.TextChanged += new System.EventHandler(this.EventChoixMenu);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioFondBlue);
            this.groupBox2.Controls.Add(this.radioFondGreen);
            this.groupBox2.Controls.Add(this.radioFondRed);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(32, 188);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(93, 138);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fond";
            this.groupBox2.Visible = false;
            // 
            // radioFondBlue
            // 
            this.radioFondBlue.AutoSize = true;
            this.radioFondBlue.Location = new System.Drawing.Point(7, 92);
            this.radioFondBlue.Name = "radioFondBlue";
            this.radioFondBlue.Size = new System.Drawing.Size(48, 19);
            this.radioFondBlue.TabIndex = 2;
            this.radioFondBlue.TabStop = true;
            this.radioFondBlue.Text = "Bleu";
            this.radioFondBlue.UseVisualStyleBackColor = true;
            // 
            // radioFondGreen
            // 
            this.radioFondGreen.AutoSize = true;
            this.radioFondGreen.Location = new System.Drawing.Point(6, 66);
            this.radioFondGreen.Name = "radioFondGreen";
            this.radioFondGreen.Size = new System.Drawing.Size(45, 19);
            this.radioFondGreen.TabIndex = 1;
            this.radioFondGreen.TabStop = true;
            this.radioFondGreen.Text = "Vert";
            this.radioFondGreen.UseVisualStyleBackColor = true;
            // 
            // radioFondRed
            // 
            this.radioFondRed.AutoSize = true;
            this.radioFondRed.Location = new System.Drawing.Point(6, 40);
            this.radioFondRed.Name = "radioFondRed";
            this.radioFondRed.Size = new System.Drawing.Size(59, 19);
            this.radioFondRed.TabIndex = 0;
            this.radioFondRed.TabStop = true;
            this.radioFondRed.Text = "Rouge";
            this.radioFondRed.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioCaractBlue);
            this.groupBox3.Controls.Add(this.radioCaractGreen);
            this.groupBox3.Controls.Add(this.radioCaractRed);
            this.groupBox3.Enabled = false;
            this.groupBox3.Location = new System.Drawing.Point(147, 188);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(99, 138);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Caractère";
            this.groupBox3.Visible = false;
            // 
            // radioCaractBlue
            // 
            this.radioCaractBlue.AutoSize = true;
            this.radioCaractBlue.Location = new System.Drawing.Point(5, 92);
            this.radioCaractBlue.Name = "radioCaractBlue";
            this.radioCaractBlue.Size = new System.Drawing.Size(48, 19);
            this.radioCaractBlue.TabIndex = 2;
            this.radioCaractBlue.TabStop = true;
            this.radioCaractBlue.Text = "Bleu";
            this.radioCaractBlue.UseVisualStyleBackColor = true;
            // 
            // radioCaractGreen
            // 
            this.radioCaractGreen.AutoSize = true;
            this.radioCaractGreen.Location = new System.Drawing.Point(5, 66);
            this.radioCaractGreen.Name = "radioCaractGreen";
            this.radioCaractGreen.Size = new System.Drawing.Size(45, 19);
            this.radioCaractGreen.TabIndex = 1;
            this.radioCaractGreen.TabStop = true;
            this.radioCaractGreen.Text = "Vert";
            this.radioCaractGreen.UseVisualStyleBackColor = true;
            // 
            // radioCaractRed
            // 
            this.radioCaractRed.AutoSize = true;
            this.radioCaractRed.Location = new System.Drawing.Point(6, 40);
            this.radioCaractRed.Name = "radioCaractRed";
            this.radioCaractRed.Size = new System.Drawing.Size(59, 19);
            this.radioCaractRed.TabIndex = 0;
            this.radioCaractRed.TabStop = true;
            this.radioCaractRed.Text = "Rouge";
            this.radioCaractRed.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radioCasseMajuscule);
            this.groupBox4.Controls.Add(this.radioCasseMinuscule);
            this.groupBox4.Enabled = false;
            this.groupBox4.Location = new System.Drawing.Point(265, 249);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(155, 77);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Casse";
            this.groupBox4.Visible = false;
            // 
            // radioCasseMajuscule
            // 
            this.radioCasseMajuscule.AutoSize = true;
            this.radioCasseMajuscule.Location = new System.Drawing.Point(7, 49);
            this.radioCasseMajuscule.Name = "radioCasseMajuscule";
            this.radioCasseMajuscule.Size = new System.Drawing.Size(79, 19);
            this.radioCasseMajuscule.TabIndex = 1;
            this.radioCasseMajuscule.TabStop = true;
            this.radioCasseMajuscule.Text = "Majuscule";
            this.radioCasseMajuscule.UseVisualStyleBackColor = true;
            // 
            // radioCasseMinuscule
            // 
            this.radioCasseMinuscule.AutoSize = true;
            this.radioCasseMinuscule.Location = new System.Drawing.Point(7, 23);
            this.radioCasseMinuscule.Name = "radioCasseMinuscule";
            this.radioCasseMinuscule.Size = new System.Drawing.Size(80, 19);
            this.radioCasseMinuscule.TabIndex = 0;
            this.radioCasseMinuscule.TabStop = true;
            this.radioCasseMinuscule.Text = "Minuscule";
            this.radioCasseMinuscule.UseVisualStyleBackColor = true;
            // 
            // FormBoutonRadio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.labelAffichage);
            this.Controls.Add(this.textBoxSaisie);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "FormBoutonRadio";
            this.Text = "CheckBox et RadioButton";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckedListBox checkedListBoxChoix;
        private System.Windows.Forms.TextBox textBoxSaisie;
        private System.Windows.Forms.Label labelAffichage;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radioFondBlue;
        private System.Windows.Forms.RadioButton radioFondGreen;
        private System.Windows.Forms.RadioButton radioCaractRed;
        private System.Windows.Forms.RadioButton radioFondRed;
        private System.Windows.Forms.RadioButton radioCaractGreen;
        private System.Windows.Forms.RadioButton radioCaractBlue;
        private System.Windows.Forms.RadioButton radioCasseMajuscule;
        private System.Windows.Forms.RadioButton radioCasseMinuscule;
    }
}