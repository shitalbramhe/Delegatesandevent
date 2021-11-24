using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegateandevent
{
    public delegate int Operation(int x, int y);
    public class DelegateDemo
    {
        public static int Addition(int a, int b)
        {
            return a + b;
        }
                
    }
}
