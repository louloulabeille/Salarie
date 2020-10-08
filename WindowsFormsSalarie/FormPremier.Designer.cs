namespace WindowsFormsSalarie
{
    partial class FormPremier
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.buttRecopier = new System.Windows.Forms.Button();
            this.buttEffacer = new System.Windows.Forms.Button();
            this.butQuitter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelCopie = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Location = new System.Drawing.Point(130, 37);
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Size = new System.Drawing.Size(481, 23);
            this.textBoxMessage.TabIndex = 0;
            this.textBoxMessage.Text = "Entrer le texte initial";
            // 
            // buttRecopier
            // 
            this.buttRecopier.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttRecopier.Location = new System.Drawing.Point(675, 37);
            this.buttRecopier.Name = "buttRecopier";
            this.buttRecopier.Size = new System.Drawing.Size(87, 23);
            this.buttRecopier.TabIndex = 1;
            this.buttRecopier.Text = "Recopier";
            this.buttRecopier.UseVisualStyleBackColor = true;
            this.buttRecopier.Click += new System.EventHandler(this.EventButtRecopier);
            // 
            // buttEffacer
            // 
            this.buttEffacer.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttEffacer.Location = new System.Drawing.Point(675, 66);
            this.buttEffacer.Name = "buttEffacer";
            this.buttEffacer.Size = new System.Drawing.Size(87, 23);
            this.buttEffacer.TabIndex = 1;
            this.buttEffacer.Text = "Effacer";
            this.buttEffacer.UseVisualStyleBackColor = true;
            this.buttEffacer.Click += new System.EventHandler(this.EventButtEffacer);
            // 
            // butQuitter
            // 
            this.butQuitter.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.butQuitter.Location = new System.Drawing.Point(675, 95);
            this.butQuitter.Name = "butQuitter";
            this.butQuitter.Size = new System.Drawing.Size(87, 23);
            this.butQuitter.TabIndex = 1;
            this.butQuitter.Text = "Quitter";
            this.butQuitter.UseVisualStyleBackColor = true;
            this.butQuitter.Click += new System.EventHandler(this.EventButtQuitter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(57, 37);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Original :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(69, 74);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Copie :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelCopie
            // 
            this.labelCopie.AutoSize = true;
            this.labelCopie.Location = new System.Drawing.Point(130, 74);
            this.labelCopie.Name = "labelCopie";
            this.labelCopie.Size = new System.Drawing.Size(0, 15);
            this.labelCopie.TabIndex = 3;
            // 
            // FormPremier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 178);
            this.Controls.Add(this.labelCopie);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butQuitter);
            this.Controls.Add(this.buttEffacer);
            this.Controls.Add(this.buttRecopier);
            this.Controls.Add(this.textBoxMessage);
            this.Name = "FormPremier";
            this.Text = "Recopier un champ dans un autre";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttRecopier;
        private System.Windows.Forms.Button buttEffacer;
        private System.Windows.Forms.Button butQuitter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelCopie;
        private System.Windows.Forms.TextBox textBoxMessage;
    }
}

