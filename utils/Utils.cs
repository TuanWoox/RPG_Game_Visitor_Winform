using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform_charts_visitor.utils
{
    public static class Utils
    {
        public static void ChangeImage(Image action, Image normal, PictureBox characterPictureBox)
        {
            if (characterPictureBox != null)
            {

                // Change the image to attack animation
                characterPictureBox.Image = action;

                // Use System.Windows.Forms.Timer to reset image after animation
                Timer resetTimer = new Timer
                {
                    Interval = 890 // Duration of the attack animation in milliseconds
                };

                resetTimer.Tick += (s, ev) =>
                {
                    resetTimer.Stop();
                    resetTimer.Dispose();

                    // Reset the image to the standing state
                    characterPictureBox.Image = normal;
                };

                resetTimer.Start();
            }
        }
    }
}
