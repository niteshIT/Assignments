using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newassignment2._1
{
    class ImmobileEquipment : Equipment
    {
        public double Weight { get; set; }

        public override EquipmentType Type => EquipmentType.Immobile;

        protected override double GetMaintenanceCost(double distance)
        {
            return Weight * distance;
        }
    }
}

