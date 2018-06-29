using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace crudCadastro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();            
        }

        SqlConnection conn = null;
        private string strConn = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=mat;Data Source=DESKTOP-BQJKA5R";
        private string strSql = string.Empty;

        private void tsb_salvar_Click(object sender, EventArgs e)
        {
            strSql = "INSERT INTO cadastro(nome, cpf, rg, email, cep, cidade, uf, bairro, rua) VALUES (@nome, @cpf, @rg, @email, @cep, @cidade, @uf, @bairro, @rua)";
            conn = new SqlConnection(strConn);
            SqlCommand cmd = new SqlCommand(strSql, conn);
            cmd.Parameters.Add("@nome", SqlDbType.VarChar).Value = txt_nome.Text;
            cmd.Parameters.Add("@cpf", SqlDbType.VarChar).Value = msk_cpf.Text;
            cmd.Parameters.Add("@rg", SqlDbType.VarChar).Value = msk_rg.Text;
            cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = txt_email.Text;
            cmd.Parameters.Add("@cep", SqlDbType.VarChar).Value = msk_cep.Text;
            cmd.Parameters.Add("@cidade", SqlDbType.VarChar).Value = txt_cidade.Text;
            cmd.Parameters.Add("@uf", SqlDbType.VarChar).Value = txt_uf.Text;
            cmd.Parameters.Add("@bairro", SqlDbType.VarChar).Value = txt_bairro.Text;
            cmd.Parameters.Add("@rua", SqlDbType.VarChar).Value = txt_rua.Text;
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("cadastro efetuado!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            txt_id.Enabled = false;
            txt_nome.Enabled = false;
            msk_cpf.Enabled = false;
            msk_rg.Enabled = false;
            txt_email.Enabled = false;
            msk_cep.Enabled = false;
            txt_cidade.Enabled = false;
            txt_uf.Enabled = false;
            txt_bairro.Enabled = false;
            txt_rua.Enabled = false;
            tsb_novo.Enabled = true;
            tsb_salvar.Enabled = false;
            tsb_editar.Enabled = false;
            tsb_cancelar.Enabled = false;
            tsb_apagar.Enabled = false;
            tsb_buscar.Enabled = true;
            tst_buscarId.Enabled = true;

            tst_buscarId.Text = "";
            txt_id.Text = "";
            txt_nome.Text = "";
            msk_cpf.Text = "";
            msk_rg.Text = "";
            txt_email.Text = "";
            msk_cep.Text = "";
            txt_cidade.Text = "";
            txt_uf.Text = "";
            txt_bairro.Text = "";
            txt_rua.Text = "";

        }

        private void tsb_buscar_Click(object sender, EventArgs e)
        {
            strSql = "SELECT * FROM cadastro WHERE id = @id";
            conn = new SqlConnection(strConn);
            SqlCommand cmd = new SqlCommand(strSql, conn);

            cmd.Parameters.Add("@id", SqlDbType.Int).Value = tst_buscarId.Text;
            
            try
            {
                if(tst_buscarId.Text == string.Empty)
                {
                    throw new Exception("Você precisa digitar um id!");
                }
                conn.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                if(dr.HasRows == false)
                {
                    throw new Exception("Id não cadastrado!");
                }
                dr.Read();

                txt_id.Text = Convert.ToString(dr["id"]);
                txt_nome.Text = Convert.ToString(dr["nome"]);
                msk_cpf.Text = Convert.ToString(dr["cpf"]);
                msk_rg.Text = Convert.ToString(dr["rg"]);
                txt_email.Text = Convert.ToString(dr["email"]);
                msk_cep.Text = Convert.ToString(dr["cep"]);
                txt_cidade.Text = Convert.ToString(dr["cidade"]);
                txt_uf.Text = Convert.ToString(dr["uf"]);
                txt_bairro.Text = Convert.ToString(dr["bairro"]);
                txt_rua.Text = Convert.ToString(dr["rua"]);
                

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            txt_id.Enabled = false;
            txt_nome.Enabled = true;
            msk_cpf.Enabled = true;
            msk_rg.Enabled = true;
            txt_email.Enabled = true;
            msk_cep.Enabled = true;
            txt_cidade.Enabled = true;
            txt_uf.Enabled = true;
            txt_bairro.Enabled = true;
            txt_rua.Enabled = true;
            tsb_novo.Enabled = false;
            tsb_salvar.Enabled = false;
            tsb_editar.Enabled = true;
            tsb_cancelar.Enabled = true;
            tsb_apagar.Enabled = true;
            tsb_buscar.Enabled = false;
            tst_buscarId.Enabled = false;

            tst_buscarId.Text = "";
            txt_nome.Focus();
        }

        private void tsb_editar_Click(object sender, EventArgs e)
        {
            strSql = "UPDATE cadastro SET nome=@nome, cpf=@cpf, rg=@rg, email=@email, cep=@cep, cidade=@cidade, uf=@uf, bairro=@bairro, rua=@rua WHERE id=@idBuscar";
            conn = new SqlConnection(strConn);
            SqlCommand cmd = new SqlCommand(strSql, conn);

            cmd.Parameters.Add("@idBuscar", SqlDbType.Int).Value = tst_buscarId.Text;

            cmd.Parameters.Add("@nome", SqlDbType.VarChar).Value = txt_nome.Text;
            cmd.Parameters.Add("@cpf", SqlDbType.VarChar).Value = msk_cpf.Text;
            cmd.Parameters.Add("@rg", SqlDbType.VarChar).Value = msk_rg.Text;
            cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = txt_email.Text;
            cmd.Parameters.Add("@cep", SqlDbType.VarChar).Value = msk_cep.Text;
            cmd.Parameters.Add("@cidade", SqlDbType.VarChar).Value = txt_cidade.Text;
            cmd.Parameters.Add("@uf", SqlDbType.VarChar).Value = txt_uf.Text;
            cmd.Parameters.Add("@bairro", SqlDbType.VarChar).Value = txt_bairro.Text;
            cmd.Parameters.Add("@rua", SqlDbType.VarChar).Value = txt_rua.Text;

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cadastro atualizado com sucesso!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            txt_id.Enabled = false;
            txt_nome.Enabled = false;
            msk_cpf.Enabled = false;
            msk_rg.Enabled = false;
            txt_email.Enabled = false;
            msk_cep.Enabled = false;
            txt_cidade.Enabled = false;
            txt_uf.Enabled = false;
            txt_bairro.Enabled = false;
            txt_rua.Enabled = false;
            tsb_novo.Enabled = true;
            tsb_salvar.Enabled = false;
            tsb_editar.Enabled = false;
            tsb_cancelar.Enabled = false;
            tsb_apagar.Enabled = false;
            tsb_buscar.Enabled = true;
            tst_buscarId.Enabled = true;

            tst_buscarId.Text = "";
            txt_id.Text = "";
            txt_nome.Text = "";
            msk_cpf.Text = "";
            msk_rg.Text = "";
            txt_email.Text = "";
            msk_cep.Text = "";
            txt_cidade.Text = "";
            txt_uf.Text = "";
            txt_bairro.Text = "";
            txt_rua.Text = "";

        }

        private void tsb_apagar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente excluir esse funcionário?", "Cuidado", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                MessageBox.Show("Operação cancelada");
            }

            else
            {
                strSql = "DELETE FROM cadastro WHERE id=@id";
                conn = new SqlConnection(strConn);
                SqlCommand cmd = new SqlCommand(strSql, conn);

                cmd.Parameters.Add("@id", SqlDbType.Int).Value = tst_buscarId.Text;

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Funcionario deletado com sucesso!");
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }

            txt_id.Enabled = false;
            txt_nome.Enabled = false;
            msk_cpf.Enabled = false;
            msk_rg.Enabled = false;
            txt_email.Enabled = false;
            msk_cep.Enabled = false;
            txt_cidade.Enabled = false;
            txt_uf.Enabled = false;
            txt_bairro.Enabled = false;
            txt_rua.Enabled = false;
            tsb_novo.Enabled = true;
            tsb_salvar.Enabled = false;
            tsb_editar.Enabled = false;
            tsb_cancelar.Enabled = false;
            tsb_apagar.Enabled = false;
            tsb_buscar.Enabled = true;
            tst_buscarId.Enabled = true;

            tst_buscarId.Text = "";
            txt_id.Text = "";
            txt_nome.Text = "";
            msk_cpf.Text = "";
            msk_rg.Text = "";
            txt_email.Text = "";
            msk_cep.Text = "";
            txt_cidade.Text = "";
            txt_uf.Text = "";
            txt_bairro.Text = "";
            txt_rua.Text = "";





        }

        private void tsb_novo_Click(object sender, EventArgs e)
        {
            txt_id.Enabled = false;
            txt_nome.Enabled = true;
            msk_cpf.Enabled = true;
            msk_rg.Enabled = true;
            txt_email.Enabled = true;
            msk_cep.Enabled = true;
            txt_cidade.Enabled = true;
            txt_uf.Enabled = true;
            txt_bairro.Enabled = true;
            txt_rua.Enabled = true;
            tsb_novo.Enabled = false;
            tsb_salvar.Enabled = true;
            tsb_editar.Enabled = false;
            tsb_cancelar.Enabled = true;
            tsb_apagar.Enabled = false;
            tsb_buscar.Enabled = false;

            tst_buscarId.Text = "";
            txt_id.Text = "";
            txt_nome.Text = "";
            msk_cpf.Text = "";
            msk_rg.Text = "";
            txt_email.Text = "";
            msk_cep.Text = "";
            txt_cidade.Text = "";
            txt_uf.Text = "";
            txt_bairro.Text = "";
            txt_rua.Text = "";
            
        }

        private void tsb_cancelar_Click(object sender, EventArgs e)
        {
            txt_id.Enabled = false;
            txt_nome.Enabled = false;
            msk_cpf.Enabled = false;
            msk_rg.Enabled = false;
            txt_email.Enabled = false;
            msk_cep.Enabled = false;
            txt_cidade.Enabled = false;
            txt_uf.Enabled = false;
            txt_bairro.Enabled = false;
            txt_rua.Enabled = false;
            tsb_novo.Enabled = true;
            tsb_salvar.Enabled = false;
            tsb_editar.Enabled = false;
            tsb_cancelar.Enabled = false;
            tsb_apagar.Enabled = false;
            tsb_buscar.Enabled = true;
            tst_buscarId.Enabled = true;

            tst_buscarId.Text = "";
            txt_id.Text = "";
            txt_nome.Text = "";
            msk_cpf.Text = "";
            msk_rg.Text = "";
            txt_email.Text = "";
            msk_cep.Text = "";
            txt_cidade.Text = "";
            txt_uf.Text = "";
            txt_bairro.Text = "";
            txt_rua.Text = "";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txt_id.Enabled = false;
            txt_nome.Enabled = false;
            msk_cpf.Enabled = false;
            msk_rg.Enabled = false;
            txt_email.Enabled = false;
            msk_cep.Enabled = false;
            txt_cidade.Enabled = false;
            txt_uf.Enabled = false;
            txt_bairro.Enabled = false;
            txt_rua.Enabled = false;
            tsb_novo.Enabled = true;
            tsb_salvar.Enabled = false;
            tsb_editar.Enabled = false;
            tsb_cancelar.Enabled = false;
            tsb_apagar.Enabled = false;
            tsb_buscar.Enabled = true;
            tst_buscarId.Enabled = true;
        }
    }
}
