using System;
using System.Windows.Forms;
using winform_charts_visitor.VistiorFile.Element;

namespace winform_charts_visitor.VistiorFile.Visitor
{
    public class DyingVisitor : ICharacterVisitor
    {
        public void Visit(Valkyrie valky)
        {
            if (valky == null || valky.GetPictureBox() == null)
                return;

            // Change the image to attack animation
            valky.GetPictureBox().Image = Properties.Resources.valkyrie_dying;

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
                valky.GetPictureBox().Image = Properties.Resources.valkyrie_idle;
            };

            resetTimer.Start();
        }

        public void Visit(Golem golem)  // <-- Moved inside AttackVisitor class
        {
            if (golem == null || golem.GetPictureBox() == null)
                return;

            // Change the image to attack animation
            golem.GetPictureBox().Image = Properties.Resources.golem_dying;

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
                golem.GetPictureBox().Image = Properties.Resources.golem_idle;
            };

            resetTimer.Start();
        }
        public void Visit(Reaper reaper)  // <-- Moved inside AttackVisitor class
        {
            if (reaper == null || reaper.GetPictureBox() == null)
                return;

            // Change the image to attack animation
            reaper.GetPictureBox().Image = Properties.Resources.reaper_dying;

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
                reaper.GetPictureBox().Image = Properties.Resources.reaper_idle;
            };

            resetTimer.Start();
        }
    }
}
