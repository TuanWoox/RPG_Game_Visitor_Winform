using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform_charts_visitor
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void lostButton1_Click(object sender, EventArgs e)
        {
            IngameMenu ingameMenu = new IngameMenu();
            ingameMenu.Show();
            this.Hide(); // Hide MainMenu first

            ingameMenu.FormClosed += (s, args) => this.Close(); // Ensures MainMenu closes when IngameMenu is closed
        }
    }
}
