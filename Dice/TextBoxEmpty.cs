using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice
{
    internal class TextBoxEmpty : Exception
    {
        public TextBoxEmpty(string msg) : base(msg)
        {
            

        }

    }

}
