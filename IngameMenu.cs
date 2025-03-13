using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using winform_charts_visitor.VistiorFile;
using winform_charts_visitor.VistiorFile.Element;

namespace winform_charts_visitor
{
    public partial class IngameMenu : Form
    {
        ObjectStructure characterList = new ObjectStructure();
        public IngameMenu()
        {
            InitializeComponent();
        }

        private void attackButton_Click(object sender, EventArgs e)
        {
            characterList.Attack();
        }
        private void runButton_Click(object sender, EventArgs e)
        {
            characterList.Run();
        }
        private void dieButton_Click(object sender, EventArgs e)
        {
            characterList.Dying();
        }

        private void IngameMenu_Load(object sender, EventArgs e)
        {
            if (characterPanel != null)
            {
                int xOffset = 25; // Start X position
                int yOffset = 40; // Start Y position

                foreach (var character in characterList.characters)
                {
                    PictureBox pic = character.GetPictureBox();

                    // Set custom position manually
                    pic.Location = new Point(xOffset, yOffset);

                    // Adjust X or Y position for the next character
                    xOffset += pic.Width + 10;  // Add space between images

                    characterPanel.Controls.Add(pic);
                }
            }
        }

        
    }
}
