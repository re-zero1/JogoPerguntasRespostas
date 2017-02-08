namespace JogoDesktop
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
            this.lblpergunta2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.rdb1 = new System.Windows.Forms.RadioButton();
            this.rbd2 = new System.Windows.Forms.RadioButton();
            this.rbd3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lblpergunta2
            // 
            this.lblpergunta2.AutoSize = true;
            this.lblpergunta2.Location = new System.Drawing.Point(39, 26);
            this.lblpergunta2.Name = "lblpergunta2";
            this.lblpergunta2.Size = new System.Drawing.Size(35, 13);
            this.lblpergunta2.TabIndex = 0;
            this.lblpergunta2.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(274, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Confirma";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rdb1
            // 
            this.rdb1.AutoSize = true;
            this.rdb1.Location = new System.Drawing.Point(121, 73);
            this.rdb1.Name = "rdb1";
            this.rdb1.Size = new System.Drawing.Size(51, 17);
            this.rdb1.TabIndex = 2;
            this.rdb1.TabStop = true;
            this.rdb1.Text = "Aizen";
            this.rdb1.UseVisualStyleBackColor = true;
            // 
            // rbd2
            // 
            this.rbd2.AutoSize = true;
            this.rbd2.Location = new System.Drawing.Point(121, 116);
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
            this.rbd3.Location = new System.Drawing.Point(121, 157);
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
            this.radioButton4.Location = new System.Drawing.Point(121, 191);
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
            this.ClientSize = new System.Drawing.Size(391, 261);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.rbd3);
            this.Controls.Add(this.rbd2);
            this.Controls.Add(this.rdb1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblpergunta2);
            this.Name = "Pergunta2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pergunta2";
            this.Load += new System.EventHandler(this.Pergunta2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblpergunta2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rdb1;
        private System.Windows.Forms.RadioButton rbd2;
        private System.Windows.Forms.RadioButton rbd3;
        private System.Windows.Forms.RadioButton radioButton4;
    }
}