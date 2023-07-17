using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace GestaoDeTickets
{
    public partial class Form1 : Form
    {
        /*------------------------------*/
        //Conexao
        static string constr = "SERVER=localhost;USER=root;PASSWORD='';DATABASE =tickets";
        MySqlConnection conexao = new MySqlConnection(constr);
        //string ID = "";    
        public Form1()
        {
            InitializeComponent();

            DisplayData();

        }

        public void DisplayData()
        {
            conexao.Open();

            string query = "SELECT * FROM ticketdetalhes";
            MySqlDataAdapter adr = new MySqlDataAdapter(query, conexao);
            DataTable dt = new DataTable();
            adr.Fill(dt);
            dataGridView1.DataSource = dt;
            this.dataGridView1.Sort(this.dataGridView1.Columns["Assento"], System.ComponentModel.ListSortDirection.Ascending);

            conexao.Close();

            int Assentos = 64;

            int ticketsagendados = dt.Rows.Count;
            txtCount.Text = dt.Rows.Count.ToString();
            txtRestantes.Text = (Assentos - ticketsagendados).ToString();

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {


            try
            {
                var StringConexao = "SERVER=localhost;USER=root;PASSWORD='';DATABASE =tickets";
                var Conexao = new MySqlConnection(StringConexao);
                Conexao.Open();
                MessageBox.Show("Conexao a BD efectuada!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar a BD" + ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNome.Text != "" && txtRota.Text != "" && txtPartida.Text != "" && txtGenero.Text != "" && txtCondicaoEspecial.Text != "" && txtDestino.Text != "")
            {

                conexao.Open();
                //         MessageBox.Show("Coction sucess");


                /*------------------------------*/

                string Assento = txtAssento.Text;
                string ID = txtID.Text;
                string Matricula = txtMatricula.Text;
                string Nome = txtNome.Text;
                string Rota = txtRota.Text;
                string Partida = txtPartida.Text;
                string Destino = txtDestino.Text;
                string CondicaoEspecial = txtCondicaoEspecial.Text;
                string Genero = txtGenero.Text;
                string DataAgendada = dateTime.Text;
                string Estado = "Pendente";

                string query = "INSERT INTO ticketdetalhes VALUES (" + Assento + " ,'" + ID + "' ,'" + Matricula + "' ,'" + Nome + "' ,'" + Rota + "' ,'" + Partida + "' ,'" + Destino + "' , '" + CondicaoEspecial + "' ,'" + Genero + "'  , '" + DataAgendada + "', '" + Estado + "')";
                MySqlCommand cmd = new MySqlCommand(query, conexao);
                int linha = cmd.ExecuteNonQuery();

                if (linha > 0)
                {
                    MessageBox.Show("Ticket Agendado com sucesso!!!");
                }
                else
                {
                    MessageBox.Show("Erro ao agendar ticket!!!");

                }
                conexao.Close();

                DisplayData();
            }
            else
            {
                MessageBox.Show("Preencha todos campos");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string Assento = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            string ID = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            string Matricula = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            string Nome = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            string Rota = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            string Partida = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            string Destino = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            string CondicaoEspecial = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            string Genero = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            string DataAgendada = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
            string Estado = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();

            txtAssento.Text = Assento;
            txtID.Text = ID;
            txtMatricula.Text = Matricula;
            txtNome.Text = Nome;
            txtRota.Text = Rota;
            txtPartida.Text = Partida;
            txtDestino.Text = Destino;
            txtCondicaoEspecial.Text = CondicaoEspecial;
            txtGenero.Text = Genero;
            dateTime.Text = DataAgendada;



        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            DialogResult kk = MessageBox.Show("Deseja mesmo Actlizar o ticket ?" + txtNome.Text, "caption", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (kk == DialogResult.Yes)
            {
                if (txtAssento.Text != "" && txtID.Text != "" && txtNome.Text != "" && txtRota.Text != "" && txtPartida.Text != "" && txtGenero.Text != "" && txtCondicaoEspecial.Text != "" && txtDestino.Text != "")
                {
                    conexao.Open();
                    string Assento = txtAssento.Text;
                    string ID = txtID.Text;
                    string Matricula = txtMatricula.Text;
                    string Nome = txtNome.Text;
                    string Rota = txtRota.Text;
                    string Partida = txtPartida.Text;
                    string Destino = txtDestino.Text;
                    string CondicaoEspecial = txtCondicaoEspecial.Text;
                    string Genero = txtGenero.Text;
                    string DataAgendada = dateTime.Text;
                    //string query = "UPDATE ticketdetalhes SET Assento= '"+Assento+"', ID='"+ID+"', Nome='"+Nome+"' ,Rota='"+Rota+"' , Partida ='"+Partida+"' ,Destino= '"+Destino+"', CondicaoEspecial='"+CondicaoEspecial+"' ,Genero ='"+Genero+"',DataAgendada ='"+DataAgendada+"'" ;
                    string query = "update tickets.ticketdetalhes set Assento='" + this.txtAssento.Text + "',ID='" + this.txtID.Text + "',Matricula='" + this.txtMatricula.Text + "',Nome='" + this.txtNome.Text + "',Rota='" + this.txtRota.Text + "',Partida='" + this.txtPartida.Text + "',Destino='" + this.txtDestino.Text + "',CondicaoEspecial='" + this.txtCondicaoEspecial.Text + "',Genero='" + this.txtGenero.Text + "',DataAgendada='" + this.dateTime.Text + "' where ID='" + this.txtID.Text + "';";

                    MySqlCommand cmd = new MySqlCommand(query, conexao);
                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        MessageBox.Show("Actualizadao com sucesso!!!!");
                    }
                    else
                    {
                        MessageBox.Show("Erro ao actualizar!!!");
                    }


                }
                else
                {
                    MessageBox.Show("Nenhuma linha selecionada para actualizacao!");
                }
            }
            conexao.Close();
            DisplayData();

        }




        private void btnApagar_Click(object sender, EventArgs e)
        {

            string ID = txtID.Text;


            //   MessageBox.Show("Deseja mesmo apagar o ticket ?",MessageBoxButtons.YesNo);
            DialogResult kk = MessageBox.Show("Deseja mesmo apagar o ticket ?" + txtNome.Text, "caption", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (kk == DialogResult.Yes)
            {

                if (ID != "")
                {
                    conexao.Open();
                    string query = "DELETE FROM `ticketdetalhes` WHERE ID = " + "'" + ID + "'" + ";";

                    MySqlCommand cmd = new MySqlCommand(query, conexao);
                    int linhas = cmd.ExecuteNonQuery();

                    if (linhas > 0)
                    {
                        MessageBox.Show("Ticket apagdo com sucesso!!");
                    }
                    else
                    {
                        MessageBox.Show("Selecionar tcicket por apagar!!");
                    }
                    conexao.Close();

                }


            }
            else
            {

                MessageBox.Show("Operacao de apagar ticket cancelada!");

            }

            DisplayData();

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
        }

        private void label8_Click(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void btnMapp_Click(object sender, EventArgs e)
        {
            string contacto = txtPhoneNumber.Text;
            string accountSid = "ACc617e57928486efea72c69c3ee64521f";
            string authToken = "0454b7bd70aee90bb1b810d35f6e96f3";

            TwilioClient.Init(accountSid, authToken);

            var message = MessageResource.Create(
                body: "Ola! " + txtNome.Text + " Seu ticket da rota " + txtRota.Text  + " " + txtPartida.Text + " " + " para " + txtDestino.Text + " " + " na data " + dateTime.Text +  " "+" foi agendado com sucesso ",
                from: new Twilio.Types.PhoneNumber("+13159187115"),
                to: new Twilio.Types.PhoneNumber("+258"+contacto)
            );

            MessageBox.Show("Enviado por SMS para " + txtNome.Text);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txtAssento.Clear();
            txtCondicaoEspecial.ResetText();
            txtDestino.Clear();
            txtGenero.ResetText();
            txtID.Clear();
            txtMatricula.ResetText();
            txtNome.Clear();
            txtPartida.Clear();
            txtPhoneNumber.Clear();
            txtRota.ResetText();


        }

        private void dateTime_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtAssento.Text != "" && txtID.Text != "" && txtNome.Text != "" && txtRota.Text != "" && txtPartida.Text != "" && txtGenero.Text != "" && txtCondicaoEspecial.Text != "" && txtDestino.Text != "")
            {
                conexao.Open();
                string Assento = txtAssento.Text;
                string ID = txtID.Text;
                string Matricula = txtMatricula.Text;
                string Nome = txtNome.Text;
                string Rota = txtRota.Text;
                string Partida = txtPartida.Text;
                string Destino = txtDestino.Text;
                string CondicaoEspecial = txtCondicaoEspecial.Text;
                string Genero = txtGenero.Text;
                string DataAgendada = dateTime.Text;
                string pago = "Pago";
                //string query = "UPDATE ticketdetalhes SET Assento= '"+Assento+"', ID='"+ID+"', Nome='"+Nome+"' ,Rota='"+Rota+"' , Partida ='"+Partida+"' ,Destino= '"+Destino+"', CondicaoEspecial='"+CondicaoEspecial+"' ,Genero ='"+Genero+"',DataAgendada ='"+DataAgendada+"'" ;
                string query = "update tickets.ticketdetalhes set Assento='" + this.txtAssento.Text + "',ID='" + this.txtID.Text + "',Matricula='" + this.txtMatricula.Text + "',Nome='" + this.txtNome.Text + "',Rota='" + this.txtRota.Text + "',Partida='" + this.txtPartida.Text + "',Destino='" + this.txtDestino.Text + "',CondicaoEspecial='" + this.txtCondicaoEspecial.Text + "',Genero='" + this.txtGenero.Text + "',DataAgendada='" + this.dateTime.Text + "',Estado='" + pago + "' where ID='" + this.txtID.Text + "';";

                MySqlCommand cmd = new MySqlCommand(query, conexao);
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    MessageBox.Show("Actualizadao com sucesso!!!!");
                }
                else
                {
                    MessageBox.Show("Erro ao actualizar!!!");
                }
                conexao.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtAssento.Text != "" && txtID.Text != "" && txtNome.Text != "" && txtRota.Text != "" && txtPartida.Text != "" && txtGenero.Text != "" && txtCondicaoEspecial.Text != "" && txtDestino.Text != "")
            {
                conexao.Open();
                string Assento = txtAssento.Text;
                string ID = txtID.Text;
                string Matricula = txtMatricula.Text;
                string Nome = txtNome.Text;
                string Rota = txtRota.Text;
                string Partida = txtPartida.Text;
                string Destino = txtDestino.Text;
                string CondicaoEspecial = txtCondicaoEspecial.Text;
                string Genero = txtGenero.Text;
                string DataAgendada = dateTime.Text;
                string pago = "Nao Pago";
                //string query = "UPDATE ticketdetalhes SET Assento= '"+Assento+"', ID='"+ID+"', Nome='"+Nome+"' ,Rota='"+Rota+"' , Partida ='"+Partida+"' ,Destino= '"+Destino+"', CondicaoEspecial='"+CondicaoEspecial+"' ,Genero ='"+Genero+"',DataAgendada ='"+DataAgendada+"'" ;
                string query = "update tickets.ticketdetalhes set Assento='" + this.txtAssento.Text + "',ID='" + this.txtID.Text + "',Matricula='" + this.txtMatricula.Text + "',Nome='" + this.txtNome.Text + "',Rota='" + this.txtRota.Text + "',Partida='" + this.txtPartida.Text + "',Destino='" + this.txtDestino.Text + "',CondicaoEspecial='" + this.txtCondicaoEspecial.Text + "',Genero='" + this.txtGenero.Text + "',DataAgendada='" + this.dateTime.Text + "',Estado='" + pago + "' where ID='" + this.txtID.Text + "';";

                MySqlCommand cmd = new MySqlCommand(query, conexao);
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    MessageBox.Show("Actualizadao com sucesso!!!!");
                }
                else
                {
                    MessageBox.Show("Erro ao actualizar!!!");
                }
                conexao.Close();

            }
        }
    }
}