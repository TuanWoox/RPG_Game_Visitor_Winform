using System;
using winform_charts_visitor.VistiorFile.Element;

namespace winform_charts_visitor.VistiorFile.Visitor
{
    public interface ICharacterVisitor
    {
        void Visit(Valkyrie valkyrie);
        void Visit(Golem golem);
        void Visit(Reaper reaper);
    }
}
