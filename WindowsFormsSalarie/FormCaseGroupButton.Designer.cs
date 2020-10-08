namespace WindowsFormsSalarie
{
    partial class FormCaseGroupButton
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
            this.textBoxSaisie = new System.Windows.Forms.TextBox();
            this.labelAffichage = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkedListBoxChoixActive = new WindowsFormsSalarie.CheckedListBoxChoix();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonFondBlue = new System.Windows.Forms.RadioButton();
            this.radioButtonFondGreen = new System.Windows.Forms.RadioButton();
            this.radioButtonFondRed = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButtonCaractBlack = new System.Windows.Forms.RadioButton();
            this.radioButtonCaractWhite = new System.Windows.Forms.RadioButton();
            this.radioButtonCaractRed = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radioButtonMajuscule = new System.Windows.Forms.RadioButton();
            this.radioButtonMinuscule = new System.Windows.Forms.RadioButton();
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
            // textBoxSaisie
            // 
            this.textBoxSaisie.Location = new System.Drawing.Point(13, 32);
            this.textBoxSaisie.Name = "textBoxSaisie";
            this.textBoxSaisie.Size = new System.Drawing.Size(426, 23);
            this.textBoxSaisie.TabIndex = 1;
            this.textBoxSaisie.TextChanged += new System.EventHandler(this.EventTextBoxSaisie);
            // 
            // labelAffichage
            // 
            this.labelAffichage.AutoSize = true;
            this.labelAffichage.Location = new System.Drawing.Point(13, 84);
            this.labelAffichage.Name = "labelAffichage";
            this.labelAffichage.Size = new System.Drawing.Size(0, 15);
            this.labelAffichage.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkedListBoxChoixActive);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(564, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 99);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choix";
            // 
            // checkedListBoxChoixActive
            // 
            this.checkedListBoxChoixActive.FormattingEnabled = true;
            this.checkedListBoxChoixActive.Items.AddRange(new object[] {
            "Couleur du fond",
            "Couleur des caractères",
            "Casse"});
            this.checkedListBoxChoixActive.Location = new System.Drawing.Point(7, 23);
            this.checkedListBoxChoixActive.Name = "checkedListBoxChoixActive";
            this.checkedListBoxChoixActive.Size = new System.Drawing.Size(171, 58);
            this.checkedListBoxChoixActive.TabBoxLie = null;
            this.checkedListBoxChoixActive.TabIndex = 0;
            this.checkedListBoxChoixActive.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.EventitemCheckChange);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonFondBlue);
            this.groupBox2.Controls.Add(this.radioButtonFondGreen);
            this.groupBox2.Controls.Add(this.radioButtonFondRed);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(50, 215);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(107, 134);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fond";
            this.groupBox2.Visible = false;
            // 
            // radioButtonFondBlue
            // 
            this.radioButtonFondBlue.AutoSize = true;
            this.radioButtonFondBlue.Location = new System.Drawing.Point(7, 75);
            this.radioButtonFondBlue.Name = "radioButtonFondBlue";
            this.radioButtonFondBlue.Size = new System.Drawing.Size(48, 19);
            this.radioButtonFondBlue.TabIndex = 2;
            this.radioButtonFondBlue.TabStop = true;
            this.radioButtonFondBlue.Tag = "Blue";
            this.radioButtonFondBlue.Text = "Bleu";
            this.radioButtonFondBlue.UseVisualStyleBackColor = true;
            this.radioButtonFondBlue.CheckedChanged += new System.EventHandler(this.EventRadioButtonChange);
            // 
            // radioButtonFondGreen
            // 
            this.radioButtonFondGreen.AutoSize = true;
            this.radioButtonFondGreen.Location = new System.Drawing.Point(7, 49);
            this.radioButtonFondGreen.Name = "radioButtonFondGreen";
            this.radioButtonFondGreen.Size = new System.Drawing.Size(45, 19);
            this.radioButtonFondGreen.TabIndex = 1;
            this.radioButtonFondGreen.TabStop = true;
            this.radioButtonFondGreen.Tag = "Green";
            this.radioButtonFondGreen.Text = "Vert";
            this.radioButtonFondGreen.UseVisualStyleBackColor = true;
            this.radioButtonFondGreen.CheckedChanged += new System.EventHandler(this.EventRadioButtonChange);
            // 
            // radioButtonFondRed
            // 
            this.radioButtonFondRed.AutoSize = true;
            this.radioButtonFondRed.Location = new System.Drawing.Point(7, 23);
            this.radioButtonFondRed.Name = "radioButtonFondRed";
            this.radioButtonFondRed.Size = new System.Drawing.Size(59, 19);
            this.radioButtonFondRed.TabIndex = 0;
            this.radioButtonFondRed.TabStop = true;
            this.radioButtonFondRed.Tag = "Red";
            this.radioButtonFondRed.Text = "Rouge";
            this.radioButtonFondRed.UseVisualStyleBackColor = true;
            this.radioButtonFondRed.CheckedChanged += new System.EventHandler(this.EventRadioButtonChange);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButtonCaractBlack);
            this.groupBox3.Controls.Add(this.radioButtonCaractWhite);
            this.groupBox3.Controls.Add(this.radioButtonCaractRed);
            this.groupBox3.Enabled = false;
            this.groupBox3.Location = new System.Drawing.Point(175, 215);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(115, 134);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Caractère";
            this.groupBox3.Visible = false;
            // 
            // radioButtonCaractBlack
            // 
            this.radioButtonCaractBlack.AutoSize = true;
            this.radioButtonCaractBlack.Location = new System.Drawing.Point(7, 75);
            this.radioButtonCaractBlack.Name = "radioButtonCaractBlack";
            this.radioButtonCaractBlack.Size = new System.Drawing.Size(48, 19);
            this.radioButtonCaractBlack.TabIndex = 2;
            this.radioButtonCaractBlack.TabStop = true;
            this.radioButtonCaractBlack.Tag = "Black";
            this.radioButtonCaractBlack.Text = "Noir";
            this.radioButtonCaractBlack.UseVisualStyleBackColor = true;
            this.radioButtonCaractBlack.CheckedChanged += new System.EventHandler(this.EventRadioButtonChange);
            // 
            // radioButtonCaractWhite
            // 
            this.radioButtonCaractWhite.AutoSize = true;
            this.radioButtonCaractWhite.Location = new System.Drawing.Point(6, 49);
            this.radioButtonCaractWhite.Name = "radioButtonCaractWhite";
            this.radioButtonCaractWhite.Size = new System.Drawing.Size(54, 19);
            this.radioButtonCaractWhite.TabIndex = 1;
            this.radioButtonCaractWhite.TabStop = true;
            this.radioButtonCaractWhite.Tag = "White";
            this.radioButtonCaractWhite.Text = "Blanc";
            this.radioButtonCaractWhite.UseVisualStyleBackColor = true;
            this.radioButtonCaractWhite.CheckedChanged += new System.EventHandler(this.EventRadioButtonChange);
            // 
            // radioButtonCaractRed
            // 
            this.radioButtonCaractRed.AutoSize = true;
            this.radioButtonCaractRed.Location = new System.Drawing.Point(7, 23);
            this.radioButtonCaractRed.Name = "radioButtonCaractRed";
            this.radioButtonCaractRed.Size = new System.Drawing.Size(59, 19);
            this.radioButtonCaractRed.TabIndex = 0;
            this.radioButtonCaractRed.TabStop = true;
            this.radioButtonCaractRed.Tag = "Red";
            this.radioButtonCaractRed.Text = "Rouge";
            this.radioButtonCaractRed.UseVisualStyleBackColor = true;
            this.radioButtonCaractRed.CheckedChanged += new System.EventHandler(this.EventRadioButtonChange);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radioButtonMajuscule);
            this.groupBox4.Controls.Add(this.radioButtonMinuscule);
            this.groupBox4.Enabled = false;
            this.groupBox4.Location = new System.Drawing.Point(321, 249);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(124, 100);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Casse";
            this.groupBox4.Visible = false;
            // 
            // radioButtonMajuscule
            // 
            this.radioButtonMajuscule.AutoSize = true;
            this.radioButtonMajuscule.Location = new System.Drawing.Point(7, 49);
            this.radioButtonMajuscule.Name = "radioButtonMajuscule";
            this.radioButtonMajuscule.Size = new System.Drawing.Size(79, 19);
            this.radioButtonMajuscule.TabIndex = 1;
            this.radioButtonMajuscule.TabStop = true;
            this.radioButtonMajuscule.Text = "Majuscule";
            this.radioButtonMajuscule.UseVisualStyleBackColor = true;
            this.radioButtonMajuscule.CheckedChanged += new System.EventHandler(this.EventRadioButtonChange);
            // 
            // radioButtonMinuscule
            // 
            this.radioButtonMinuscule.AutoSize = true;
            this.radioButtonMinuscule.Location = new System.Drawing.Point(7, 23);
            this.radioButtonMinuscule.Name = "radioButtonMinuscule";
            this.radioButtonMinuscule.Size = new System.Drawing.Size(80, 19);
            this.radioButtonMinuscule.TabIndex = 0;
            this.radioButtonMinuscule.TabStop = true;
            this.radioButtonMinuscule.Text = "Minuscule";
            this.radioButtonMinuscule.UseVisualStyleBackColor = true;
            this.radioButtonMinuscule.CheckedChanged += new System.EventHandler(this.EventRadioButtonChange);
            // 
            // FormCaseGroupButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 397);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelAffichage);
            this.Controls.Add(this.textBoxSaisie);
            this.Controls.Add(this.label1);
            this.Name = "FormCaseGroupButton";
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
        private System.Windows.Forms.TextBox textBoxSaisie;
        private System.Windows.Forms.Label labelAffichage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private CheckedListBoxChoix checkedListBoxChoixActive;
        private System.Windows.Forms.RadioButton radioButtonFondGreen;
        private System.Windows.Forms.RadioButton radioButtonFondRed;
        private System.Windows.Forms.RadioButton radioButtonFondBlue;
        private System.Windows.Forms.RadioButton radioButtonCaractBlack;
        private System.Windows.Forms.RadioButton radioButtonCaractWhite;
        private System.Windows.Forms.RadioButton radioButtonCaractRed;
        private System.Windows.Forms.RadioButton radioButtonMajuscule;
        private System.Windows.Forms.RadioButton radioButtonMinuscule;
    }
}