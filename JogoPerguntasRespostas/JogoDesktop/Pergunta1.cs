﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoDesktop
{
    public partial class Pergunta1 : Form
    {
        public Pergunta1()
        {
            InitializeComponent();
        }

        private void Pergunta1_Load(object sender, EventArgs e)
        {
            lblPergunta.Text = "Qual cidade ocorreu terremoto";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rdb3.Checked == true)
            {
                MessageBox.Show("ACERTOU");
                

            }
            else
            {
                MessageBox.Show("ERROU");
                this.Close();
            }
        }
    }
}
