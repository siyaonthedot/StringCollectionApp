using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using StringCollectionApp.Model;


namespace StringCollectionApp
{
    public class Program
    {
        static void Main(string[] args)
        {

            var col = new StringCollection();
            col.AddString("White");
            col.AddString("Red");
            col.AddString("Black");
            Console.WriteLine("string ouput : " + col.ToString());
            Console.ReadKey();

        }
    }

}
