using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace MigrationBug
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Press enter to begin");
            Console.ReadLine();

            using (var client = new HttpClient())
                Console.WriteLine(client.GetStringAsync("http://www.contoso.com").Result);

            Console.WriteLine("Finished! Press enter to exit.");
            Console.ReadLine();
        }
    }
}
