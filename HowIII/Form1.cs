using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HowIII
{
    public partial class Formulario : Form
    {
        public string tipo = "";

        public Formulario()
        {
            InitializeComponent();
        }

        private void Formulario_Load(object sender, EventArgs e)
        {
            SelecionarDadosEAtualizar();
            cbCor.SelectedItem = 0;
        }

    

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            tipo = "Básico";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            tipo = "Completo";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            tipo = "Luxuoso";
        }

        private void VerificaCampos()
        {
            if(tbAno.Text == "" || tbModelo.Text == "" || tbAno.Text == "" || tbDescricao.Text == "" || cbCor.SelectedItem == null || tipo == "" || tbPreco.Text == "")
            {
                MessageBox.Show("Preencha os campos para inserir algo!");
            } else
            {
                InserirItens();
            }
        }

        private void LimparLinhas()
        {
            tbId.Clear();
            tbModelo.Clear();
            tbAno.Clear();
            tbMarca.Clear();
            tbPreco.Clear();
            tbDescricao.Clear();
            cbCor.SelectedItem = 0;
            tipo = "";
            rbBasico.Checked = false;
            rbCompleto.Checked = false;
            rbLuxuoso.Checked = false;
        }

        private MySqlConnectionStringBuilder Conexao()
        {
            MySqlConnectionStringBuilder conexaoBD = new MySqlConnectionStringBuilder();
            conexaoBD.Server = "127.0.0.1";
            conexaoBD.Database = "veiculos";
            conexaoBD.UserID = "root";
            conexaoBD.Password = "";
            conexaoBD.SslMode = 0;
            return conexaoBD;
        }

        public void SelecionarDadosEAtualizar()
        {
            MySqlConnectionStringBuilder conexaoBD = Conexao();
            MySqlConnection realizaConexacoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexacoBD.Open();

                MySqlCommand comandoMySql = realizaConexacoBD.CreateCommand();
                comandoMySql.CommandText = "SELECT * FROM cadastro_veiculos";
                MySqlDataReader reader = comandoMySql.ExecuteReader();

                dgPrincipal.Rows.Clear();

                while (reader.Read())
                {
                    DataGridViewRow row = (DataGridViewRow)dgPrincipal.Rows[0].Clone();
                    row.Cells[0].Value = reader.GetInt32(0);
                    row.Cells[1].Value = reader.GetString(1);
                    row.Cells[2].Value = reader.GetString(2);
                    row.Cells[3].Value = reader.GetString(3);
                    row.Cells[4].Value = reader.GetString(4);
                    row.Cells[5].Value = reader.GetString(5);
                    row.Cells[6].Value = reader.GetString(6);
                    row.Cells[7].Value = reader.GetString(7);
                    dgPrincipal.Rows.Add(row);
                }

                realizaConexacoBD.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("A conexão não foi realizada!");
                Console.WriteLine(ex);
            }
        }


        public void InserirItens()
        {
            MySqlConnectionStringBuilder conexaoBD = Conexao();
            MySqlConnection realizaConexacoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexacoBD.Open();

                MySqlCommand comandoMySql = realizaConexacoBD.CreateCommand();

                comandoMySql.CommandText = "INSERT INTO cadastro_veiculos (modelo,ano_fabricacao,tipo,preco,marca,cor,descricao) " +
                    "VALUES('" + tbModelo.Text + "', '" + tbAno.Text + "','" + tipo + "', '" + tbPreco.Text + "','" + tbMarca.Text + "','" + cbCor.SelectedItem.ToString() + "','"+ tbDescricao.Text +"')";
                comandoMySql.ExecuteNonQuery();

                realizaConexacoBD.Close();
                MessageBox.Show("Registro inserido com sucesso!");
                SelecionarDadosEAtualizar();
                LimparLinhas();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            VerificaCampos();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if(tbId.Text != "")
            {
                if (rbBasico.Checked)
                {
                    tipo = "Basico";
                }
                else if (rbCompleto.Checked)
                {
                    tipo = "Completo";
                }
                else
                {
                    tipo = "Luxuoso";
                }

                MySqlConnectionStringBuilder conexaoBD = Conexao();
                MySqlConnection realizaConexacoBD = new MySqlConnection(conexaoBD.ToString());
                try
                {
                    realizaConexacoBD.Open();

                    MySqlCommand comandoMySql = realizaConexacoBD.CreateCommand();
                    comandoMySql.CommandText = "UPDATE cadastro_veiculos SET modelo = '" +
                        "" + tbModelo.Text + "', " +
                        "ano_fabricacao = '" + tbAno.Text + "', " +
                        "tipo = '" + tipo + "', " +
                        "preco = '" + tbPreco.Text + "', " +
                        "marca = '" + tbMarca.Text + "', " +
                        "cor = '" + cbCor.SelectedItem + "', " +
                        "descricao = '" + tbDescricao.Text + "' " +
                        " WHERE id = " + Convert.ToInt16(tbId.Text) + "";
                    comandoMySql.ExecuteNonQuery();

                    realizaConexacoBD.Close();
                    MessageBox.Show("Registro número: "+tbId.Text+" atualizado com sucesso!");
                    SelecionarDadosEAtualizar();
                    LimparLinhas();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Houve um erro ao atualizar o registro!\n\n"+ex.Message.ToString());
                }
            } else
            {
                MessageBox.Show("Selecione um registro antes de tentar alterar!");
            }
        }

        private void dgPrincipal_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgPrincipal.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgPrincipal.CurrentRow.Selected = true;
                tbId.Text = dgPrincipal.Rows[e.RowIndex].Cells["colId"].FormattedValue.ToString();
                tbModelo.Text = dgPrincipal.Rows[e.RowIndex].Cells["colModelo"].FormattedValue.ToString();
                tbAno.Text = dgPrincipal.Rows[e.RowIndex].Cells["colAno"].FormattedValue.ToString();
                   
                if(dgPrincipal.Rows[e.RowIndex].Cells["colTipo"].FormattedValue.ToString() == "Basico")
                {
                    rbBasico.Checked = true;
                } 
                else if (dgPrincipal.Rows[e.RowIndex].Cells["colTipo"].FormattedValue.ToString() == "Completo")
                {
                    rbCompleto.Checked = true;
                } 
                else
                {
                    rbLuxuoso.Checked = true;
                }

                tbPreco.Text = dgPrincipal.Rows[e.RowIndex].Cells["colPreco"].FormattedValue.ToString();
                tbMarca.Text = dgPrincipal.Rows[e.RowIndex].Cells["colMarca"].FormattedValue.ToString();
                cbCor.SelectedItem = dgPrincipal.Rows[e.RowIndex].Cells["colCor"].FormattedValue.ToString();
                tbDescricao.Text = dgPrincipal.Rows[e.RowIndex].Cells["colDescricao"].FormattedValue.ToString();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparLinhas();
            tbModelo.Focus();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if(tbId.Text != "")
            {
                MySqlConnectionStringBuilder conexaoBD = Conexao();
                MySqlConnection realizaConexacoBD = new MySqlConnection(conexaoBD.ToString());
                try
                {
                    realizaConexacoBD.Open();

                    MySqlCommand comandoMySql = realizaConexacoBD.CreateCommand();
                    comandoMySql.CommandText = "DELETE FROM cadastro_veiculos WHERE id = " + tbId.Text + "";

                    comandoMySql.ExecuteNonQuery();

                    realizaConexacoBD.Close();
                    MessageBox.Show("Registro número: " + tbId.Text + " deletado com sucesso!");
                    SelecionarDadosEAtualizar();
                    LimparLinhas();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Houve um problema ao tentar deletar registro!");
                }
            } else
            {
                MessageBox.Show("Selecione um registro para excluir!");
            }
        }
    }
}
