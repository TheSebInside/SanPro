using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SanPro
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        // Menu Hover Events
        private void Close_MouseHover(object sender, EventArgs e)
        {
            Close.BackgroundImage = Properties.Resources.CloseWindowHover;
        }
        private void Close_MouseLeave(object sender, EventArgs e)
        {
            Close.BackgroundImage = Properties.Resources.CloseWindow;
        }
        private void Minimize_MouseHover(object sender, EventArgs e)
        {
            Minimize.BackgroundImage = Properties.Resources.MinimizeWindow;
        }
        private void Minimize_MouseLeave(object sender, EventArgs e)
        {
            Minimize.BackgroundImage = Properties.Resources.MinimizeWindow;
        }
    }
}
³