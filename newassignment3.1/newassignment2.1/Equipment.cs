using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newassignment2._1
{
    public abstract class Equipment
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double DistanceMoved { get; protected set; } = 0;
        public double MaintenanceCost { get; protected set; } = 0;
        public abstract EquipmentType Type { get; }

        public virtual void MoveBy(double distance)
        {
            DistanceMoved += distance;
            MaintenanceCost += GetMaintenanceCost(distance);
        }
        public void printdetail()
        {
            Console.WriteLine("Name :{0} Description: {1}", this.Name, this.Description);
        }

        protected abstract double GetMaintenanceCost(double distance);
    }
}
