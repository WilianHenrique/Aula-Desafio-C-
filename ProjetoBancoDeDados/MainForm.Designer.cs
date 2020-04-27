/*
 * Created by SharpDevelop.
 * User: silva
 * Date: 26/04/2020
 * Time: 02:47
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ProjetoBancoDeDados
{
	partial class Servidor
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button Executar;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txt1;
		private System.Windows.Forms.TextBox txt2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txt3;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txt4;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.RichTextBox txt5;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Servidor));
			this.Executar = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.txt1 = new System.Windows.Forms.TextBox();
			this.txt2 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txt3 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txt4 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txt5 = new System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
			// 
			// Executar
			// 
			this.Executar.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.Executar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Executar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Executar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.Executar.Location = new System.Drawing.Point(364, 30);
			this.Executar.Name = "Executar";
			this.Executar.Size = new System.Drawing.Size(101, 47);
			this.Executar.TabIndex = 0;
			this.Executar.Text = "Executar";
			this.Executar.UseVisualStyleBackColor = false;
			this.Executar.Click += new System.EventHandler(this.ExecutarClick);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.SystemColors.Control;
			this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label1.Location = new System.Drawing.Point(26, 17);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(50, 20);
			this.label1.TabIndex = 2;
			this.label1.Text = "Servidor";
			// 
			// txt1
			// 
			this.txt1.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.txt1.Location = new System.Drawing.Point(82, 17);
			this.txt1.Name = "txt1";
			this.txt1.Size = new System.Drawing.Size(120, 20);
			this.txt1.TabIndex = 3;
			this.txt1.TextChanged += new System.EventHandler(this.Txt1TextChanged);
			// 
			// txt2
			// 
			this.txt2.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.txt2.Location = new System.Drawing.Point(82, 57);
			this.txt2.Name = "txt2";
			this.txt2.Size = new System.Drawing.Size(120, 20);
			this.txt2.TabIndex = 5;
			this.txt2.TextChanged += new System.EventHandler(this.Txt2TextChanged);
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.SystemColors.Control;
			this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label2.Location = new System.Drawing.Point(26, 60);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(50, 20);
			this.label2.TabIndex = 4;
			this.label2.Text = "Usuário";
			// 
			// txt3
			// 
			this.txt3.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.txt3.Location = new System.Drawing.Point(82, 105);
			this.txt3.Name = "txt3";
			this.txt3.Size = new System.Drawing.Size(120, 20);
			this.txt3.TabIndex = 7;
			this.txt3.TextChanged += new System.EventHandler(this.Txt3TextChanged);
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.SystemColors.Control;
			this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label3.Location = new System.Drawing.Point(26, 105);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(50, 20);
			this.label3.TabIndex = 6;
			this.label3.Text = "Senha";
			// 
			// txt4
			// 
			this.txt4.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.txt4.Location = new System.Drawing.Point(82, 145);
			this.txt4.Name = "txt4";
			this.txt4.Size = new System.Drawing.Size(120, 20);
			this.txt4.TabIndex = 9;
			this.txt4.TextChanged += new System.EventHandler(this.Txt4TextChanged);
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.SystemColors.Control;
			this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label4.Location = new System.Drawing.Point(26, 148);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(50, 17);
			this.label4.TabIndex = 8;
			this.label4.Text = "Banco";
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.SystemColors.Control;
			this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label5.Location = new System.Drawing.Point(34, 192);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(42, 17);
			this.label5.TabIndex = 10;
			this.label5.Text = "SQL";
			this.label5.Click += new System.EventHandler(this.Label5Click);
			// 
			// txt5
			// 
			this.txt5.BackColor = System.Drawing.SystemColors.Menu;
			this.txt5.Location = new System.Drawing.Point(84, 189);
			this.txt5.Name = "txt5";
			this.txt5.Size = new System.Drawing.Size(297, 96);
			this.txt5.TabIndex = 11;
			this.txt5.Text = "";
			this.txt5.TextChanged += new System.EventHandler(this.Txt5TextChanged);
			// 
			// Servidor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(510, 308);
			this.Controls.Add(this.txt5);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txt4);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txt3);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txt2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txt1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Executar);
			this.Name = "Servidor";
			this.Text = "ProjetoBancoDeDados";
			this.Load += new System.EventHandler(this.ServidorLoad);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
