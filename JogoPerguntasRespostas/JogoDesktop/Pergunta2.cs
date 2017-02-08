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
        int id_jogador_banco;
        public Pergunta2(int id_jogador)
        {
            InitializeComponent();
            id_jogador_banco = id_jogador;
        }

        private void Pergunta2_Load(object sender, EventArgs e)
        {
            lblpergunta2.Text = "Qual foi o Vilão que enganou o elenco inteiro";
        }



        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conexao = new SqlConnection("Server=AME0556325W10-1\\SQLEXPRESS;Database=db_PerguntasERespostas;Trusted_Connection=Yes"))
            {
                using (SqlCommand comando = new SqlCommand("insert into tb_Perguntas(Pergunta, resposta_correta, id_jogador) values(@Pt, @Resposcorreta, @ID_JOGADOR)", conexao))
                {
                    comando.Parameters.AddWithValue("Pt", lblpergunta2.Text);
                    comando.Parameters.AddWithValue("Resposcorreta", rdb1.Text);
                    comando.Parameters.AddWithValue("ID_JOGADOR", id_jogador_banco);
                    conexao.Open();
                    comando.ExecuteNonQuery();
                }
                if (rdb1.Checked == true)
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
    }
}
