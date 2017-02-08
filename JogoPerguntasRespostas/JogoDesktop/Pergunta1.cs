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
    public partial class Pergunta1 : Form
    {
        int id_jogador_banco;
        public Pergunta1(int id_jogador)
        {
            InitializeComponent();
            id_jogador_banco = id_jogador;
        }

        private void Pergunta1_Load(object sender, EventArgs e)
        {
            lblPergunta.Text = "Qual cidade ocorreu terremoto";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conexao = new SqlConnection("Server=AME0556325W10-1\\SQLEXPRESS;Database=db_PerguntasERespostas;Trusted_Connection=Yes"))
            {
                using (SqlCommand comando = new SqlCommand("insert into tb_perguntas(Pergunta, resposta_correta, id_jogador) values(@Pt, @Resposcorreta, @ID_JOGADOR)", conexao))
                {
                    comando.Parameters.AddWithValue("Pt",lblPergunta.Text );
                    comando.Parameters.AddWithValue("Resposcorreta",rdb3.Text );
                    comando.Parameters.AddWithValue("ID_JOGADOR", id_jogador_banco);
                    conexao.Open();
                    comando.ExecuteNonQuery();
                }
                if (rdb3.Checked == true)
                {
                    MessageBox.Show("ACERTOU");
                    Pergunta2 p2 = new Pergunta2(id_jogador_banco);
                    p2.ShowDialog();


                }
                else
                {
                    MessageBox.Show("ERROU");
                    Pergunta2 p2 = new Pergunta2(id_jogador_banco);
                    p2.ShowDialog();
                   // this.Close();
                }
            }
        }
    }
}
