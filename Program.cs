using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Lab_10___Pedro_Naretto
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly modelo = Assembly.LoadFile(@"../../municipality - library - PedroNaretto/ClassLibrary1.dll");
        }
    }
}
