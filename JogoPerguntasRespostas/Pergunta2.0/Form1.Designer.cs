namespace Pergunta2._0
{
    partial class Pergunta2
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
            this.btn = new System.Windows.Forms.Button();
            this.lblPergunta2 = new System.Windows.Forms.Label();
            this.rbd1 = new System.Windows.Forms.RadioButton();
            this.rbd2 = new System.Windows.Forms.RadioButton();
            this.rbd3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(343, 208);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(136, 41);
            this.btn.TabIndex = 0;
            this.btn.Text = "Confirmar";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblPergunta2
            // 
            this.lblPergunta2.AutoSize = true;
            this.lblPergunta2.Location = new System.Drawing.Point(225, 30);
            this.lblPergunta2.Name = "lblPergunta2";
            this.lblPergunta2.Size = new System.Drawing.Size(35, 13);
            this.lblPergunta2.TabIndex = 1;
            this.lblPergunta2.Text = "label1";
            // 
            // rbd1
            // 
            this.rbd1.AutoSize = true;
            this.rbd1.Location = new System.Drawing.Point(140, 76);
            this.rbd1.Name = "rbd1";
            this.rbd1.Size = new System.Drawing.Size(51, 17);
            this.rbd1.TabIndex = 2;
            this.rbd1.TabStop = true;
            this.rbd1.Text = "Aizen";
            this.rbd1.UseVisualStyleBackColor = true;
            // 
            // rbd2
            // 
            this.rbd2.AutoSize = true;
            this.rbd2.Location = new System.Drawing.Point(140, 116);
            this.rbd2.Name = "rbd2";
            this.rbd2.Size = new System.Drawing.Size(98, 17);
            this.rbd2.TabIndex = 3;
            this.rbd2.TabStop = true;
            this.rbd2.Text = "Uchiha Madara";
            this.rbd2.UseVisualStyleBackColor = true;
            // 
            // rbd3
            // 
            this.rbd3.AutoSize = true;
            this.rbd3.Location = new System.Drawing.Point(140, 158);
            this.rbd3.Name = "rbd3";
            this.rbd3.Size = new System.Drawing.Size(63, 17);
            this.rbd3.TabIndex = 4;
            this.rbd3.TabStop = true;
            this.rbd3.Text = "Lelouch";
            this.rbd3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(140, 196);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(50, 17);
            this.radioButton4.TabIndex = 5;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Obito";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // Pergunta2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 261);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.rbd3);
            this.Controls.Add(this.rbd2);
            this.Controls.Add(this.rbd1);
            this.Controls.Add(this.lblPergunta2);
            this.Controls.Add(this.btn);
            this.Name = "Pergunta2";
            this.Text = "Pergunta2";
            this.Load += new System.EventHandler(this.Pergunta2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Label lblPergunta2;
        private System.Windows.Forms.RadioButton rbd1;
        private System.Windows.Forms.RadioButton rbd2;
        private System.Windows.Forms.RadioButton rbd3;
        private System.Windows.Forms.RadioButton radioButton4;
    }
}

