using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2._2
{
    class DuckManagement
    {

        private List<Duck> Inventory = new List<Duck>();
        public void AddDuck(Duck duck)
        {
            
            Inventory.Add(duck);
        }
        public void Deleteduck(string name)
        {
            Duck duck = Inventory.FirstOrDefault(e => e.Name == name);
            if (duck != null)
            {
                Inventory.Remove(duck);
            }

        }
        
        public void DeleteAll()
        {
            Inventory.Clear();
        }
        public List<Duck> SortByWeight()
        {
            return Inventory.OrderBy(Duck => Duck.Weight).ToList();
        }
        public List<Duck> SortByWings()
        {
            return Inventory.OrderBy(Duck => Duck.NoofWings).ToList();
        }
    }
}
