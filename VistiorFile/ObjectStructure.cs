using System;
using System.Collections.Generic;
using winform_charts_visitor.VistiorFile.Element;
using winform_charts_visitor.VistiorFile.Visitor;

namespace winform_charts_visitor.VistiorFile
{
    public class ObjectStructure
    {
        public List<ICharacter> characters = new List<ICharacter>();
        AttackVisitor attackVisitor = new AttackVisitor();
        RunVisitor runVisitor = new RunVisitor();
        DyingVisitor dyingVisitor = new DyingVisitor();

        public ObjectStructure()
        {
            characters.Add(new Valkyrie()); // Ensure Valkyrie constructor is correctly defined
            characters.Add(new Golem());
            characters.Add(new Reaper());
        }
        public void Attack()
        {
            foreach(var character in characters)
            {
                character.Accept(attackVisitor);
            }
        }
        public void Run()
        {
            foreach (var character in characters)
            {
                character.Accept(runVisitor);
            }
        }
        public void Dying()
        {
            foreach (var character in characters)
            {
                character.Accept(dyingVisitor);
            }
        }
        
    }
}
