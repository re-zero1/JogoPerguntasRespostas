namespace JogoDesktop
{
    partial class Pergunta5
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
            this.rdb4 = new System.Windows.Forms.RadioButton();
            this.rdb3 = new System.Windows.Forms.RadioButton();
            this.rdb2 = new System.Windows.Forms.RadioButton();
            this.rdb1 = new System.Windows.Forms.RadioButton();
            this.btn5 = new System.Windows.Forms.Button();
            this.lblpergunta5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rdb4
            // 
            this.rdb4.AutoSize = true;
            this.rdb4.Location = new System.Drawing.Point(80, 205);
            this.rdb4.Name = "rdb4";
            this.rdb4.Size = new System.Drawing.Size(63, 17);
            this.rdb4.TabIndex = 11;
            this.rdb4.TabStop = true;
            this.rdb4.Text = "Lelouch";
            this.rdb4.UseVisualStyleBackColor = true;
            // 
            // rdb3
            // 
            this.rdb3.AutoSize = true;
            this.rdb3.Location = new System.Drawing.Point(80, 171);
            this.rdb3.Name = "rdb3";
            this.rdb3.Size = new System.Drawing.Size(56, 17);
            this.rdb3.TabIndex = 10;
            this.rdb3.TabStop = true;
            this.rdb3.Text = "Castiel";
            this.rdb3.UseVisualStyleBackColor = true;
            // 
            // rdb2
            // 
            this.rdb2.AutoSize = true;
            this.rdb2.Location = new System.Drawing.Point(80, 130);
            this.rdb2.Name = "rdb2";
            this.rdb2.Size = new System.Drawing.Size(58, 17);
            this.rdb2.TabIndex = 9;
            this.rdb2.TabStop = true;
            this.rdb2.Text = "Akame";
            this.rdb2.UseVisualStyleBackColor = true;
            // 
            // rdb1
            // 
            this.rdb1.AutoSize = true;
            this.rdb1.Location = new System.Drawing.Point(80, 87);
            this.rdb1.Name = "rdb1";
            this.rdb1.Size = new System.Drawing.Size(66, 17);
            this.rdb1.TabIndex = 8;
            this.rdb1.TabStop = true;
            this.rdb1.Text = "Kurosaki";
            this.rdb1.UseVisualStyleBackColor = true;
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(233, 231);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(75, 23);
            this.btn5.TabIndex = 7;
            this.btn5.Text = "Confirma";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // lblpergunta5
            // 
            this.lblpergunta5.AutoSize = true;
            this.lblpergunta5.Location = new System.Drawing.Point(41, 34);
            this.lblpergunta5.Name = "lblpergunta5";
            this.lblpergunta5.Size = new System.Drawing.Size(35, 13);
            this.lblpergunta5.TabIndex = 6;
            this.lblpergunta5.Text = "label1";
            this.lblpergunta5.Click += new System.EventHandler(this.lblpergunta5_Click);
            // 
            // Pergunta5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 299);
            this.Controls.Add(this.rdb4);
            this.Controls.Add(this.rdb3);
            this.Controls.Add(this.rdb2);
            this.Controls.Add(this.rdb1);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.lblpergunta5);
            this.Name = "Pergunta5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pergunta5";
            this.Load += new System.EventHandler(this.lblpergunta5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdb4;
        private System.Windows.Forms.RadioButton rdb3;
        private System.Windows.Forms.RadioButton rdb2;
        private System.Windows.Forms.RadioButton rdb1;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Label lblpergunta5;
    }
}