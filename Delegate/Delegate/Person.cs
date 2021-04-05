using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    class Person
    {
        public void AddtoCGPA(int math, int phy)
        {
            Console.WriteLine("Added mark to math {0} & phy {1}",math,phy);
        }
    }
}
