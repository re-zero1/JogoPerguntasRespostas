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
    public partial class Pergunta3 : Form
    {
        int id_jogador_banco;
        public Pergunta3(int id_jogador)
        {
            InitializeComponent();
            id_jogador_banco = id_jogador;
        }

        private void Pergunta3_Load(object sender, EventArgs e)
        {
            lblPergunta3.Text = "Quem foi o primeiro campeão internacional de DOTA2";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conexao = new SqlConnection("Server=AME0556325W10-1\\SQLEXPRESS;Database=db_PerguntasERespostas;Trusted_Connection=Yes"))
            {
                using (SqlCommand comando = new SqlCommand("insert into tb_Perguntas(Pergunta, resposta_correta, id_jogador) values(@Pt, @Resposcorreta, @ID_JOGADOR)", conexao))
                {
                    comando.Parameters.AddWithValue("Pt", lblPergunta3.Text);
                    comando.Parameters.AddWithValue("Resposcorreta", rdb2.Text);
                    comando.Parameters.AddWithValue("ID_JOGADOR", id_jogador_banco);
                    conexao.Open();
                    comando.ExecuteNonQuery();
                }
                if (rdb2.Checked == true)
                {
                    MessageBox.Show("ACERTOU");
                    Pergunta4 p4 = new Pergunta4(id_jogador_banco);
                    p4.ShowDialog();





                }
                else
                {
                    MessageBox.Show("ERROU");
                    Pergunta4 p4 = new Pergunta4(id_jogador_banco);
                    p4.ShowDialog();
                    //this.Close();
                }
            }
        }
    }
}
