using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pergunta2._0
{
    public partial class Pergunta2 : Form
    {
        public Pergunta2()
        {
            InitializeComponent();
        }

        private void Pergunta2_Load(object sender, EventArgs e)
        {
            lblPergunta2.Text = "qual nome do vilão que enganou o elenco inteiro no anime";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                using (SqlConnection conexao = new SqlConnection("Server=AME0556325W10-1\\SQLEXPRESS;Database=db_PerguntasERespostas;Trusted_Connection=Yes"))
                {
                    using (SqlCommand comando = new SqlCommand("insert into tb_Perguntas(Pergunta, resposta_correta) values(@Pt, @Resposcorreta)", conexao))
                    {
                        comando.Parameters.AddWithValue("Pt", lblPergunta2.Text);
                        comando.Parameters.AddWithValue("Resposcorreta", rbd1.Text);
                        conexao.Open();
                        comando.ExecuteNonQuery();
                    }
                    if (rbd1.Checked == true)
                    {
                        MessageBox.Show("ACERTOU");
                        Per
                        p1.ShowDialog();


                    }
                    else
                    {
                        MessageBox.Show("ERROU");
                        this.Close();
                    }
                }
    }
}
