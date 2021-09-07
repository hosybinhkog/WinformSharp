using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Pages
{
    public partial class NavigationForm : Form
    {

        public NavigationForm()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            iconButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            panel2.Height = iconButton1.Height - 4;
            panel2.Top = iconButton1.Top + 2;
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            iconButton4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            panel2.Height = iconButton4.Height - 4;
            panel2.Top = iconButton4.Top + 2;
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            iconButton3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            panel2.Height = iconButton3.Height - 4;
            panel2.Top = iconButton3.Top + 2;
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            iconButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            panel2.Height = iconButton2.Height - 4;
            panel2.Top = iconButton2.Top + 2;
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            FormLogon newFormLogin = new FormLogon();
            newFormLogin.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
