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
    public partial class Pergunta5 : Form
    {
        int id_jogador_banco;
        public Pergunta5(int id_jogador)
        {
            InitializeComponent();
            id_jogador_banco = id_jogador;
        }

        private void lblpergunta5_Load(object sender, EventArgs e)
        {
            lblpergunta5.Text = "Qual e o nome do protagonista que teve sua mãe morta pela propria familia";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            using (SqlConnection conexao = new SqlConnection("Server=AME0556325W10-1\\SQLEXPRESS;Database=db_PerguntasERespostas;Trusted_Connection=Yes"))
            {
                using (SqlCommand comando = new SqlCommand("insert into tb_Perguntas(Pergunta, resposta_correta, id_jogador) values(@Pt, @Resposcorreta, @ID_JOGADOR)", conexao))
                {
                    comando.Parameters.AddWithValue("Pt", lblpergunta5.Text);
                    comando.Parameters.AddWithValue("Resposcorreta", rdb4.Text);
                    comando.Parameters.AddWithValue("ID_JOGADOR", id_jogador_banco);
                    conexao.Open();
                    comando.ExecuteNonQuery();
                }
                if (rdb4.Checked == true)
                {
                    MessageBox.Show("ACERTOU");

                    this.Close();




                }
                else
                {
                    MessageBox.Show("ERROU");
                    this.Close();

                }
            }
        }

        private void lblpergunta5_Click(object sender, EventArgs e)
        {

        }
    }
}
