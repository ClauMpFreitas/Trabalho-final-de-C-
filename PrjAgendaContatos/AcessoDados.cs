using System.Windows.Forms;
using System;
using MySql.Data.MySqlClient;
using System.Data;

namespace PrjAgendaContatos
{
	public class AcessoDados
	{
		public MySqlConnection AbrirConexao()
		{
			string strconexao = "server=localhost; uid=root; password=; database=bdagendacontatos";
			MySqlConnection BancoDados;
			try
			{
				BancoDados = new MySqlConnection(strconexao);
				BancoDados.Open();
				return BancoDados;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro na conexão com o banco!" +ex.ToString(),"Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			return null;
		}
		
		public void Inserir (string nomeaux, string emailaux, string telefoneaux)
		{//Início do método Inserir
			MySqlConnection conexao;
			MySqlCommand cmd;
			string Sql;
			
			conexao=AbrirConexao();
			try{
				if (conexao != null)
				{
					Sql="insert into pessoas values (null, '"+nomeaux+"', '"+emailaux+"', '"+telefoneaux+"')";
					cmd = new MySqlCommand(Sql, conexao);
					cmd.ExecuteNonQuery();
				}
			}
			catch (Exception ex){
				MessageBox.Show("Erro na gravação: " +ex.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			finally{
				conexao.Close();
			}
		}//Fim do método Inserir
		
		public void Alterar(int idaux, string nomeaux, string emailaux, string telefoneaux)
		{//Início do método Alterar
			MySqlConnection conexao;
			MySqlCommand cmd;
			string Sql;
			
			conexao = AbrirConexao();
			try{
				if (conexao != null)
				{
					Sql = "update pessoas set nome = '"+nomeaux+"', email = '"+emailaux+"', telefone = '"+telefoneaux+"' where id = "+idaux;
					cmd = new MySqlCommand(Sql, conexao);
					cmd.ExecuteNonQuery();
				}
			}
			catch (Exception ex){
				MessageBox.Show("Erro na alteração: " +ex.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			finally{
				conexao.Close();
			}
		}//Fim do método Alterar
		
		public void Excluir (int idaux)
		{//Início do método Excluir
			MySqlConnection conexao;
			MySqlCommand cmd;
			string Sql;
			
			conexao = AbrirConexao();
			try{
				if (conexao != null)
				{
					Sql = "delete from pessoas where id=" +idaux;
					cmd = new MySqlCommand (Sql, conexao);
					cmd.ExecuteNonQuery();
				}
			}
			catch (Exception ex){
				MessageBox.Show("Erro na exclusão: " +ex.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			finally{
				conexao.Close();
			}
		}//Fim do método Excluir
		
		public DataTable Consultar(string filtro)
		{//Início do método Consultar
			MySqlConnection conexao = null;
			MySqlCommand cmd = null;
			string Sql = "";
			
			try
			{
				if (!string.IsNullOrEmpty(filtro))
				{
					Sql = "select * from pessoas where " + filtro;
				}
				else
				{
					Sql = "select * from pessoas";
				}

				conexao = AbrirConexao();

				if (conexao != null)
				{
					cmd = new MySqlCommand(Sql, conexao);
					cmd.CommandType = CommandType.Text;
					MySqlDataAdapter da = new MySqlDataAdapter(cmd);
					DataTable registros = new DataTable();
					da.Fill(registros);
					return registros;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro na consulta: " + ex.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			finally
			{
				if (conexao != null)
				{
					conexao.Close();
				}
			}
			return null;
		}//Fim do método Consultar
	}//Fim da classe
}