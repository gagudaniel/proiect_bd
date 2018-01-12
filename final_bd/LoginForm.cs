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

        private void FirstNameTextBox_Click(object sender, EventArgs e)
        {
            TextBox current_textbox = (TextBox)sender;
            if (current_textbox.Text == "First name") current_textbox.Text = "";
        }

        private void FirstNameTextBox_Validated(object sender, EventArgs e)
        {
            TextBox current_textbox = (TextBox)sender;
            if (current_textbox.Text == "") current_textbox.Text = "First name";
        }

        private void LastNameTextBox_Click(object sender, EventArgs e)
        {
            TextBox current_textbox = (TextBox)sender;
            if (current_textbox.Text == "Last name") current_textbox.Text = "";
        }

        private void LastNameTextBox_Validated(object sender, EventArgs e)
        {
            TextBox current_textbox = (TextBox)sender;
            if (current_textbox.Text == "") current_textbox.Text = "Last name";
        }

        private void EmailTextBox_Click(object sender, EventArgs e)
        {
            TextBox current_textbox = (TextBox)sender;
            if (current_textbox.Text == "Email") current_textbox.Text = "";
        }

        private void EmailTextBox_Validated(object sender, EventArgs e)
        {
            TextBox current_textbox = (TextBox)sender;
            if (current_textbox.Text == "") current_textbox.Text = "Email";
        }

        private void PINTextBox_Click(object sender, EventArgs e)
        {
            TextBox current_textbox = (TextBox)sender;
            if (current_textbox.Text == "PIN") current_textbox.Text = "";
        }

        private void PINTextBox_Validated(object sender, EventArgs e)
        {
            TextBox current_textbox = (TextBox)sender;
            if (current_textbox.Text == "") current_textbox.Text = "PIN";
        }

        private void PasswordTextBox_Click(object sender, EventArgs e)
        {
            TextBox current_textbox = (TextBox)sender;
            if (current_textbox.Text == "Password") current_textbox.Text = "";
        }

        private void PasswordTextBox_Validated(object sender, EventArgs e)
        {
            TextBox current_textbox = (TextBox)sender;
            if (current_textbox.Text == "") current_textbox.Text = "Password";
        }

        private void ConfirmPasswordTextBox_Click(object sender, EventArgs e)
        {
            TextBox current_textbox = (TextBox)sender;
            if (current_textbox.Text == "Confirm password") current_textbox.Text = "";
        }

        private void ConfirmPasswordTextBox_Validated(object sender, EventArgs e)
        {
            TextBox current_textbox = (TextBox)sender;
            if (current_textbox.Text == "") current_textbox.Text = "Confirm password";
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            AppForm app_main_form = new AppForm();
            Hide();
            app_main_form.ShowDialog();
            Close();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {

        }

        private void EmailLoginTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void BarPanel_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}
