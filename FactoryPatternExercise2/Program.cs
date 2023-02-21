using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What database would you like to use? A list, SQL, or Mongo?");
            var userResponse = Console.ReadLine();            
            Product soap = new Product() { Name = "Dawn", Price = 1.55 };
            Product medicine = new Product() { Name = "Tylenol", Price = 2.99 };
           
            IDataAccess accessType = DataAccessFactory.GetDataAccessType(userResponse);
            if (accessType != null)
            {
                var productList = accessType.SaveData();
                productList.Add(soap);
                productList.Add(medicine);
                accessType.LoadData(productList);

            }          
                      
            
        }
    }
}


