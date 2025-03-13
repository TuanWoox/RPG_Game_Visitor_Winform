﻿using System;
using System.Windows.Forms;
using winform_charts_visitor.VistiorFile.Visitor;

namespace winform_charts_visitor.VistiorFile.Element
{
    public class Golem : ICharacter
    {
        public PictureBox pictureBox;  // Private PictureBox instance

        public Golem()
        {
            // Create PictureBox inside Valkyrie
            pictureBox = new PictureBox
            {
                Size = new System.Drawing.Size(254, 274), // Set size
                BackColor = System.Drawing.Color.Transparent, // Optional
                SizeMode = PictureBoxSizeMode.Zoom, // Fit image
                Image = Properties.Resources.golem_idle, // Default image

            };
        }


        public PictureBox GetPictureBox()
        {
            return pictureBox;
        }

        public void Accept(ICharacterVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
