using System;
using System.Windows.Forms;
using winform_charts_visitor.utils;
using winform_charts_visitor.VistiorFile.Element;

namespace winform_charts_visitor.VistiorFile.Visitor
{
    public class RunVisitor : ICharacterVisitor
    {
        public void Visit(Valkyrie valky)
        {
            if (valky == null || valky.GetPictureBox() == null)
                return;

            Utils.ChangeImage(Properties.Resources.valkyrie_run, Properties.Resources.valkyrie_idle, valky.GetPictureBox());
        }

        public void Visit(Golem golem)
        {
            if (golem == null || golem.GetPictureBox() == null)
                return;

            Utils.ChangeImage(Properties.Resources.golem_run, Properties.Resources.golem_idle, golem.GetPictureBox());
        }

        public void Visit(Reaper reaper)
        {
            if (reaper == null || reaper.GetPictureBox() == null)
                return;

            Utils.ChangeImage(Properties.Resources.reaper_run, Properties.Resources.reaper_idle, reaper.GetPictureBox());
        }
    }
}