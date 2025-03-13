using System.Windows.Forms;
using winform_charts_visitor.VistiorFile.Visitor;

namespace winform_charts_visitor.VistiorFile
{
    public interface ICharacter
    {
        void Accept(ICharacterVisitor visitor);
        PictureBox GetPictureBox(); // Fix: Added semicolon and PascalCase
    }
}
