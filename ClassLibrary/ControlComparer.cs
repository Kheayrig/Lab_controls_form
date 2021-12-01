using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    class ControlTypeColorComparer : IComparer<Lab_Control>
    {
        public int Compare(Lab_Control x, Lab_Control y)
        {
            int th = GetNumType(x);
            int oth = GetNumType(y);
            if (x == y) return 0;
            else if (th != oth) return th.CompareTo(oth);
            else return x.Color.CompareTo(y.Color);
        }
        private int GetNumType(Lab_Control obj)
        {
            if (obj is Lab_RadioButton) return 1;
            else if (obj is Lab_Button) return 2;
            else if (obj is Lab_Label) return 4;
            else return 3;
        }
    }
    class ControlFontComparer : IComparer<Lab_Control>
    {
        public int Compare(Lab_Control x, Lab_Control y)
        {
            return x.Font.CompareTo(y.Font);
        }
    }
}
