using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProjetoBancoDeDados
{
	public partial class Servidor : Form
	{
		public Servidor()
		{
			InitializeComponent();
		}
				
		void ExecutarClick(object sender, EventArgs e)
		{
			MySqlConnectionStringBuilder string_executar = new MySqlConnectionStringBuilder ();
			
			string_executar.Server = txt1.Text;
			string_executar.UserID = txt2.Text;
			string_executar.Password = txt3.Text;
			string_executar.Database = txt4.Text;
			string_executar.Port = 3306;
			
			MySqlConnection executar = new MySqlConnection();
			executar.ConnectionString = string_executar.ConnectionString;
			
			try 
			{
			executar.Open();
			MessageBox.Show ("Executou!");
			
			MySqlCommand comando = new MySqlCommand();
			comando.CommandText=txt5.Text;
			comando.Connection=executar;
			comando.ExecuteNonQuery();
			
			}
			catch (Exception err)
			{
			MessageBox.Show ("Erro ao conectar, verifique os campos!");
			}
			finally
			{
				executar.Close();
			}
			
			/*
			string_executar.Server = "remotemysql.com";
			string_executar.UserID = "nPq2IsXovm";
			string_executar.Password = "XEqkMhZAJ2";
			string_executar.Database = "nPq2IsXovm";
			string_executar.Port = 3306;
			
			*/
			
		}
		void Txt1TextChanged(object sender, EventArgs e)
		{
			
		}
		void Txt2TextChanged(object sender, EventArgs e)
		{
			
		}
		void Txt3TextChanged(object sender, EventArgs e)
		{
			
		}
		void Txt4TextChanged(object sender, EventArgs e)
		{
			
		}
		void TextBox1TextChanged(object sender, EventArgs e)
		{
	
		}
		void Panel1Paint(object sender, PaintEventArgs e)
		{
			
		}
		void Label5Click(object sender, EventArgs e)
		{
	
		}
		void Txt5TextChanged(object sender, EventArgs e)
		{
	
		}
		void ServidorLoad(object sender, EventArgs e)
		{
	
		}
			
		
		
		
	}
}
