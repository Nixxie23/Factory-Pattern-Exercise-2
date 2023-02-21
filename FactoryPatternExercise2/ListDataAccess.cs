using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public class ListDataAccess : IDataAccess
    {
        public void LoadData(List<Product> list)
        {
            Console.WriteLine("I am reading data from a list.");
            foreach(var item in list)
            {
                Console.WriteLine($"{item.Name} costs {item.Price}");
            }            
        }

        public List<Product> SaveData()
        {
            Console.WriteLine("I am saving data to a list.");
            return new List<Product>();
        }
    }
}
