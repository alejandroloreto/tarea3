/*
 * Created by SharpDevelop.
 * User: CANO
 * Date: 23/10/2013
 * Time: 12:08 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace sesion
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		string usuario = "alex";
		string pass = "1234";
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void UsuarioClick(object sender, EventArgs e)
		{
			
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			
			if(textBox1.Text == usuario && textBox2.Text == pass){
				MessageBox.Show("aceptado");
			}
			else MessageBox.Show("Usuario y contraseña incorrectas");
		}
	}
}
