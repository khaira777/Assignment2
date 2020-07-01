using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            TiktokManager.Initialize();
            TiktokManager.Show();
            TiktokManager.Show("khaira");
            TiktokManager.Show(50);
            TiktokManager.Show(Audience.Group);

            Console.ReadLine();
        }
    }
}
