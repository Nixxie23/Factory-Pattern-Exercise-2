using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public class SQLDataAccess : IDataAccess
    {
        public void LoadData(List<Product> list)
        {
            Console.WriteLine("I am reading data from a SQL database.");
            foreach (var item in list)
            {
                Console.WriteLine($"{item.Name} costs {item.Price}");
            }
        }

        public List<Product> SaveData()
        {
            Console.WriteLine("I am saving data to a SQL database.");
            return new List<Product>();
        }
    }
}
