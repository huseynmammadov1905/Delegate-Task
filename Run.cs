using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp14;
namespace ConsoleApp14
{
   public delegate void Func(string s);
    public class Run
    {

        public void runFunc(Func func,string str)
        {
            func.Invoke(str);
        }
    }
}
