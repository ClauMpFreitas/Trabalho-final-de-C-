
namespace PrjAgendaContatos
{
	partial class FrmContatos
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnNovo = new System.Windows.Forms.Button();
			this.btnSalvar = new System.Windows.Forms.Button();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.btnExcluir = new System.Windows.Forms.Button();
			this.TbcDados = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.mskTelefone = new System.Windows.Forms.MaskedTextBox();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.txtNome = new System.Windows.Forms.TextBox();
			this.txtCodigo = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.cmbCampo = new System.Windows.Forms.ComboBox();
			this.cmbOperador = new System.Windows.Forms.ComboBox();
			this.txtValor = new System.Windows.Forms.TextBox();
			this.btnPesquisar = new System.Windows.Forms.Button();
			this.dvgDados = new System.Windows.Forms.DataGridView();
			this.TbcDados.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dvgDados)).BeginInit();
			this.SuspendLayout();
			// 
			// btnNovo
			// 
			this.btnNovo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.btnNovo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnNovo.Location = new System.Drawing.Point(34, 12);
			this.btnNovo.Name = "btnNovo";
			this.btnNovo.Size = new System.Drawing.Size(75, 43);
			this.btnNovo.TabIndex = 0;
			this.btnNovo.Text = "Iniciar";
			this.btnNovo.UseVisualStyleBackColor = false;
			this.btnNovo.Click += new System.EventHandler(this.BtnNovoClick);
			// 
			// btnSalvar
			// 
			this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.btnSalvar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnSalvar.Location = new System.Drawing.Point(151, 12);
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.Size = new System.Drawing.Size(75, 43);
			this.btnSalvar.TabIndex = 1;
			this.btnSalvar.Text = "Gravar";
			this.btnSalvar.UseVisualStyleBackColor = false;
			this.btnSalvar.Click += new System.EventHandler(this.BtnSalvarClick);
			// 
			// btnCancelar
			// 
			this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.btnCancelar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnCancelar.Location = new System.Drawing.Point(267, 12);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(87, 43);
			this.btnCancelar.TabIndex = 2;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = false;
			this.btnCancelar.Click += new System.EventHandler(this.BtnCancelarClick);
			// 
			// btnExcluir
			// 
			this.btnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.btnExcluir.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnExcluir.Location = new System.Drawing.Point(387, 12);
			this.btnExcluir.Name = "btnExcluir";
			this.btnExcluir.Size = new System.Drawing.Size(75, 43);
			this.btnExcluir.TabIndex = 3;
			this.btnExcluir.Text = "Excluir";
			this.btnExcluir.UseVisualStyleBackColor = false;
			this.btnExcluir.Click += new System.EventHandler(this.BtnExcluirClick);
			// 
			// TbcDados
			// 
			this.TbcDados.Controls.Add(this.tabPage1);
			this.TbcDados.Location = new System.Drawing.Point(23, 71);
			this.TbcDados.Name = "TbcDados";
			this.TbcDados.SelectedIndex = 0;
			this.TbcDados.Size = new System.Drawing.Size(452, 157);
			this.TbcDados.TabIndex = 4;
			// 
			// tabPage1
			// 
			this.tabPage1.BackColor = System.Drawing.Color.PeachPuff;
			this.tabPage1.Controls.Add(this.mskTelefone);
			this.tabPage1.Controls.Add(this.txtEmail);
			this.tabPage1.Controls.Add(this.txtNome);
			this.tabPage1.Controls.Add(this.txtCodigo);
			this.tabPage1.Controls.Add(this.label4);
			this.tabPage1.Controls.Add(this.label3);
			this.tabPage1.Controls.Add(this.label2);
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(444, 131);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Dados";
			// 
			// mskTelefone
			// 
			this.mskTelefone.Location = new System.Drawing.Point(78, 94);
			this.mskTelefone.Mask = "(00) 00000-0000";
			this.mskTelefone.Name = "mskTelefone";
			this.mskTelefone.Size = new System.Drawing.Size(132, 26);
			this.mskTelefone.TabIndex = 7;
			// 
			// txtEmail
			// 
			this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
			this.txtEmail.Location = new System.Drawing.Point(78, 67);
			this.txtEmail.MaxLength = 150;
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(229, 26);
			this.txtEmail.TabIndex = 6;
			// 
			// txtNome
			// 
			this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtNome.Location = new System.Drawing.Point(78, 40);
			this.txtNome.MaxLength = 50;
			this.txtNome.Name = "txtNome";
			this.txtNome.Size = new System.Drawing.Size(229, 26);
			this.txtNome.TabIndex = 5;
			// 
			// txtCodigo
			// 
			this.txtCodigo.Enabled = false;
			this.txtCodigo.Location = new System.Drawing.Point(78, 13);
			this.txtCodigo.Name = "txtCodigo";
			this.txtCodigo.Size = new System.Drawing.Size(112, 26);
			this.txtCodigo.TabIndex = 4;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(7, 94);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 3;
			this.label4.Text = "Telefone";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(7, 67);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "E-mail";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(7, 40);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Nome";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(6, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Código";
			// 
			// cmbCampo
			// 
			this.cmbCampo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.cmbCampo.FormattingEnabled = true;
			this.cmbCampo.Items.AddRange(new object[] {
			"id",
			"nome",
			"email",
			"telefone"});
			this.cmbCampo.Location = new System.Drawing.Point(23, 251);
			this.cmbCampo.Name = "cmbCampo";
			this.cmbCampo.Size = new System.Drawing.Size(110, 26);
			this.cmbCampo.TabIndex = 5;
			// 
			// cmbOperador
			// 
			this.cmbOperador.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.cmbOperador.FormattingEnabled = true;
			this.cmbOperador.Items.AddRange(new object[] {
			"=",
			">",
			"<",
			">=",
			"<=",
			"<>"});
			this.cmbOperador.Location = new System.Drawing.Point(139, 251);
			this.cmbOperador.Name = "cmbOperador";
			this.cmbOperador.Size = new System.Drawing.Size(121, 26);
			this.cmbOperador.TabIndex = 6;
			// 
			// txtValor
			// 
			this.txtValor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtValor.Location = new System.Drawing.Point(267, 251);
			this.txtValor.Name = "txtValor";
			this.txtValor.Size = new System.Drawing.Size(100, 26);
			this.txtValor.TabIndex = 7;
			// 
			// btnPesquisar
			// 
			this.btnPesquisar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.btnPesquisar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnPesquisar.Location = new System.Drawing.Point(373, 251);
			this.btnPesquisar.Name = "btnPesquisar";
			this.btnPesquisar.Size = new System.Drawing.Size(102, 26);
			this.btnPesquisar.TabIndex = 8;
			this.btnPesquisar.Text = "Pesquisar";
			this.btnPesquisar.UseVisualStyleBackColor = false;
			this.btnPesquisar.Click += new System.EventHandler(this.BtnPesquisarClick);
			// 
			// dvgDados
			// 
			this.dvgDados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dvgDados.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
			this.dvgDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dvgDados.Location = new System.Drawing.Point(23, 290);
			this.dvgDados.Name = "dvgDados";
			this.dvgDados.Size = new System.Drawing.Size(452, 150);
			this.dvgDados.TabIndex = 9;
			this.dvgDados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DvgDadosCellContentClick);
			// 
			// FrmContatos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.ClientSize = new System.Drawing.Size(495, 462);
			this.Controls.Add(this.dvgDados);
			this.Controls.Add(this.btnPesquisar);
			this.Controls.Add(this.txtValor);
			this.Controls.Add(this.cmbOperador);
			this.Controls.Add(this.cmbCampo);
			this.Controls.Add(this.TbcDados);
			this.Controls.Add(this.btnExcluir);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnSalvar);
			this.Controls.Add(this.btnNovo);
			this.Name = "FrmContatos";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Agenda Pessoal";
			this.Load += new System.EventHandler(this.FrmContatosLoad);
			this.TbcDados.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dvgDados)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		private System.Windows.Forms.DataGridView dvgDados;
		private System.Windows.Forms.Button btnPesquisar;
		private System.Windows.Forms.TextBox txtValor;
		private System.Windows.Forms.ComboBox cmbOperador;
		private System.Windows.Forms.ComboBox cmbCampo;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtCodigo;
		private System.Windows.Forms.TextBox txtNome;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.MaskedTextBox mskTelefone;
		private System.Windows.Forms.TabControl TbcDados;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.Button btnExcluir;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Button btnSalvar;
		private System.Windows.Forms.Button btnNovo;
	}
}
