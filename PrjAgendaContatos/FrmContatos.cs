using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace PrjAgendaContatos
{
	public partial class FrmContatos : Form
	{
		private string Estado;
		public FrmContatos()
		{
			InitializeComponent();
			
			// Crie um objeto ToolTip
			ToolTip toolTip = new ToolTip();

			// Defina as mensagens de texto das dicas de ferramenta para cada botão
			toolTip.SetToolTip(btnNovo, "Clique para iniciar a inserção de um novo contato");
			toolTip.SetToolTip(btnSalvar, "Clique para gravar os dados digitados");
			toolTip.SetToolTip(btnCancelar, "Clique aqui para cancelar a operação");
			toolTip.SetToolTip(btnExcluir, "Clique aqui para excluir um contato");
			toolTip.SetToolTip(btnPesquisar, "Clique aqui para pesquisar um contato");

			Estado = "Ler";
			AbreBanco();
		}
		private void limparCampos()
		{
			txtCodigo.Clear();
			txtNome.Clear();
			txtEmail.Clear();
			mskTelefone.Clear();
		}
		public void AbreBanco()
		{
			AcessoDados db = new AcessoDados();
			string parametro;
			
			parametro = "id>0";
			dvgDados.DataSource = db.Consultar(parametro);
			db = null;
		}
		
		void FrmContatosLoad(object sender, EventArgs e)
		{
			AbreBanco();
			Estado = "Alterar";
		}
		
		void BtnSalvarClick(object sender, EventArgs e)
		{
			try{
				Pessoa p = new Pessoa();
				p.Pnome = txtNome.Text;
				p.Pemail = txtEmail.Text;
				p.Ptelefone = mskTelefone.Text;
				if (Estado == "Inserir"){
					p.InserirPessoa();
				}
				else if (Estado == "Alterar"){
					p.Pcodigo = Convert.ToInt32(txtCodigo.Text);
					p.AlterarPessoa();
				}
				p = null;
				Estado = "Ler";
				limparCampos();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro ao cadastrar contato" +ex.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			AbreBanco();
		}
		
		void BtnCancelarClick(object sender, EventArgs e)
		{
			limparCampos();
		}
		
		void BtnNovoClick(object sender, EventArgs e)
		{
			Estado = "Inserir";
			limparCampos();
			txtNome.Focus();
		}
		
		void BtnExcluirClick(object sender, EventArgs e)
		{
			if (MessageBox.Show("Deseja excluir este contato? ", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				Pessoa p = new Pessoa();
				p.Pcodigo = Convert.ToInt32(txtCodigo.Text);
				p.Pnome = txtNome.Text;
				p.Pemail = txtEmail.Text;
				p.Ptelefone = mskTelefone.Text;
				p.ExcluirPessoa();
				limparCampos();
				p = null;
				AbreBanco();
			}
		}
		
		void BtnPesquisarClick(object sender, EventArgs e)
		{
			AcessoDados db = new AcessoDados();
			string parametro;
			
			parametro = cmbCampo.Text + " " + cmbOperador.Text + "'" + txtValor.Text + "'";
			dvgDados.DataSource = db.Consultar(parametro);
			db = null;
			Estado = "Alterar";
		}
		
		void DvgDadosCellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			Pessoa p = new Pessoa();
			p.CarregarPessoa(Convert.ToInt32(dvgDados.CurrentRow.Cells[0].Value.ToString()));
			txtCodigo.Text = Convert.ToString(p.Pcodigo);
			txtNome.Text = p.Pnome;
			txtEmail.Text = p.Pemail;
			mskTelefone.Text = p.Ptelefone;
			Estado = "Alterar";
		}
	}
}
