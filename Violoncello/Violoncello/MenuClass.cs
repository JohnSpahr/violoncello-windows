using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Violoncello
{
    class MenuClass : ProfessionalColorTable
    {
        public override Color MenuItemSelected
        {
            get { return Color.DarkGray; }
        }
        public override Color MenuItemSelectedGradientBegin
        {
            get { return Color.DarkGray; }
        }
        public override Color MenuItemSelectedGradientEnd
        {
            get { return Color.DarkGray; }
        }

        public override Color MenuItemBorder
        {
            get { return Color.DarkGray; }
        }
    }
}
