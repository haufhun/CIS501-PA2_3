using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Class_Library;

namespace Portfolio_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new Account();
            var ui = new UserInterface();
            DataBase.GetInfoFromFile(new StreamReader("Ticker.txt"));

            var c = new Controller(a, ui);
            c.RunProgram();
        }
    }
}
