using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final_bd
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            SignInPanel.BringToFront();
            SignUpUnderlinePanel.BackColor = SignInPanel.BackColor;
            SignInUnderlinePanel.BackColor = Color.White;
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            SignInPanel.BringToFront();
            SignUpUnderlinePanel.BackColor = SignInPanel.BackColor;
            SignInUnderlinePanel.BackColor = Color.White;
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            SignUpPanel.BringToFront();
            SignInUnderlinePanel.BackColor = SignUpPanel.BackColor;
            SignUpUnderlinePanel.BackColor = Color.White;
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int mouseX = 0, mouseY = 0;
        bool mouseDown;
        private void BarPanel_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }

        private void BarPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                mouseX = MousePosition.X - 250;
                mouseY = MousePosition.Y - 35;
                this.SetDesktopLocation(mouseX, mouseY);
            }
        }

        private void BarPanel_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}
