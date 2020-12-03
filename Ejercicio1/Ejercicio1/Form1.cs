#define KE
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        int formMouseX;
        int formMouseY;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea salir?", "Mi Aplicación",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            #if KEY
            
            if (e.KeyChar == (char)Keys.Escape)
            {
                this.Text = "Mouse Tester";
            }
            else 
            {
                this.Text = e.KeyChar.ToString();
            }
            #endif

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
             formMouseX = e.X;
             formMouseY = e.Y;

            this.Text = String.Format("x:{0,4} y:{1,4}", formMouseX, formMouseY);
           
        }

        private void Button_MouseMove(object sender, MouseEventArgs e)
        {
            int buttonMouseX = e.X + formMouseX;
            int buttonMouseY = e.Y + formMouseY;
            this.Text = String.Format("x:{0,4} y:{1,4}", buttonMouseX  , buttonMouseY  );
        }

        private void Button_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                button1.BackColor = Color.Yellow;
            }
            else if (e.Button == MouseButtons.Right)
            {
                button2.BackColor = Color.Yellow;
            }
            else 
            {
                button1.BackColor = Color.Yellow;
                button2.BackColor = Color.Yellow;
            }
        }

        private void Button_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                button1.BackColor = DefaultBackColor;
                
            }
            else if (e.Button == MouseButtons.Right)
            {
                button2.BackColor = DefaultBackColor;
            }
            else
            {
                button1.BackColor = DefaultBackColor;
                button2.BackColor = DefaultBackColor;
            }
        }


        private void Form1_MouseLeave(object sender, EventArgs e)
        {
            this.Text = "Mouse Tester";
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            #if !KEY
            if (e.KeyCode == Keys.Escape)
            {
                this.Text = "Mouse Tester";
            }
            else 
            {
                this.Text = e.KeyCode.ToString(); ;
            }
            #endif
        }

    }
}
