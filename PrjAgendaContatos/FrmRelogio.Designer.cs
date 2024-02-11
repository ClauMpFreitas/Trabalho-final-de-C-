
namespace PrjAgendaContatos
{
	partial class FrmRelogio
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
			this.components = new System.ComponentModel.Container();
			this.LblHora = new System.Windows.Forms.Label();
			this.TmrRelogio = new System.Windows.Forms.Timer(this.components);
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// LblHora
			// 
			this.LblHora.BackColor = System.Drawing.Color.Sienna;
			this.LblHora.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.LblHora.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.LblHora.Location = new System.Drawing.Point(87, 43);
			this.LblHora.Name = "LblHora";
			this.LblHora.Size = new System.Drawing.Size(262, 93);
			this.LblHora.TabIndex = 0;
			this.LblHora.Text = "Relógio";
			this.LblHora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// TmrRelogio
			// 
			this.TmrRelogio.Enabled = true;
			this.TmrRelogio.Interval = 1000;
			this.TmrRelogio.Tick += new System.EventHandler(this.TmrRelogioTick);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button1.Location = new System.Drawing.Point(170, 177);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(94, 30);
			this.button1.TabIndex = 1;
			this.button1.Text = "Sair";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// FrmRelogio
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.ClientSize = new System.Drawing.Size(436, 232);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.LblHora);
			this.Name = "FrmRelogio";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Relógio";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Timer TmrRelogio;
		private System.Windows.Forms.Label LblHora;
	}
}
