using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Client.Service1;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var client = new TempServiceClient())
            {
                Console.WriteLine(client.PobierzTemp());
            }
            Console.ReadLine();

        }
    }
}
