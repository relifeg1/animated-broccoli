using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LoingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName, password = string.Empty;

            Console.Write("Enter User Name :");
            userName = Console.ReadLine();
            Console.Write("Enter a password :");
            password = Console.ReadLine();

            //مكان إنشاء المستند
            using (StreamWriter sw = new StreamWriter(File.Create("C:\\Users\\MSI\\Desktop\\Developer Program\\Fil\\Pro\\Login\\1.txt")))
            {
                sw.WriteLine(userName);               
                sw.WriteLine(password);
                sw.Close();
            }

            Console.WriteLine("Done....");

            Console.Read();



        }
    }
}
