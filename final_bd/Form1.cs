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
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
            MainPanel.BringToFront();
            MenuBarPanel.BringToFront();
        }
        

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {
            //MenuButton.BackColor = Color.DeepSkyBlue;
        }

        private void MenuPanel_Paint(object sender, PaintEventArgs e)
        {
            //MenuButton.BackColor = Color.White;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MainPanel.BringToFront();
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        int mouseX = 0,mouseY=0;
        bool mouseDown;

        private void MenuBarPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if(mouseDown)
            {
                mouseX = MousePosition.X -550;
                mouseY = MousePosition.Y -35;
                this.SetDesktopLocation(mouseX, mouseY);
            }
        }

        private void MenuBarPanel_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void MenuBarPanel_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }

        bool menu = true;

        private void MainPanel_MouseClick(object sender, MouseEventArgs e)
        {
            if (menu == false)
            {
                MainPanel.BringToFront();
                menu = true;
            }
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            
            if (menu == true)
            {
                MenuPanel.BringToFront();
                menu = false;
            }
            else
            {
                MainPanel.BringToFront();
                menu = true;
            }
        }



    }
}
