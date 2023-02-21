using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public interface IDataAccess
    {
        public List<Product> SaveData(); 
        public void LoadData(List<Product> list);
      
    }
}
