using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newassignment2._1
{
    class MobileEquipment:Equipment
    {
        public int NumberOfWheels { get; set; }

        public override EquipmentType Type => EquipmentType.Mobile;

        protected override double GetMaintenanceCost(double distance)
        {
            return NumberOfWheels * distance;
        }
    }
}
