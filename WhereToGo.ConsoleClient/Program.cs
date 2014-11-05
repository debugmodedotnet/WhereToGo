using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhereToGo.Infrastructure;

namespace WhereToGo.ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            RDbContext context = new RDbContext();
            try
            {
                var result = context.Restaurants;
                Console.WriteLine(result);
                Console.ReadKey(true);
            }
            catch(Exception ex)
            {
                throw ex; 
            }

        }
    }
}
