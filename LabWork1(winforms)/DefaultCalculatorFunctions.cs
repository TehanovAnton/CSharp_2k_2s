using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork1_winforms_
{
    interface DefaultCalculatorFunctions
    {
        void Division(object sender, EventArgs e);
        void Multiplication(object sender, EventArgs e);
        void Plus(object sender, EventArgs e);
        void Minus(object sender, EventArgs e);
        void Equal(object sender, EventArgs e);
    }
}
