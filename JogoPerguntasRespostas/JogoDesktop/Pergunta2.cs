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

namespace JogoDesktop
{
    public partial class Pergunta2 : Form
    {
        public Pergunta2()
        {
            InitializeComponent();
        }

        private void Pergunta2_Load(object sender, EventArgs e)
        {
            lblpergunta2.Text = "Qual cidade ocorreu terremoto";
        }



        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conexao = new SqlConnection("Server=AME0556325W10-1\\SQLEXPRESS;Database=db_PerguntasERespostas;Trusted_Connection=Yes"))
            {
                using (SqlCommand comando = new SqlCommand("insert into tb_Perguntas(Pergunta, resposta_correta, id_jogador) values(@Pt, @Resposcorreta, 2)", conexao))
                {
                    comando.Parameters.AddWithValue("Pt", lblpergunta2.Text);
                    comando.Parameters.AddWithValue("Resposcorreta", rdb1.Text);
                    conexao.Open();
                    comando.ExecuteNonQuery();
                }
                if (rdb1.Checked == true)
                {
                    MessageBox.Show("ACERTOU");
                    Pergunta3 p3 = new Pergunta3();
                    p3.ShowDialog();





                }
                else
                {
                    MessageBox.Show("ERROU");
                    this.Close();
                }
            }
        }
    }
}
