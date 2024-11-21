using OOP.AbstractCommercialBuildings;
using OOP.Constructions.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.CommercialBuilding
{
    internal class CommercialBuilding : AbstractCommercialBuilding
    {
        public CommercialBuilding(CreateConstructionDto construction, string businessType) : base(construction, businessType)
        {
        }
        public override void OpenBusiness()
        {
            Console.WriteLine($"The {BusinessType} business is now open in the commercial building!");
        }
    }
}
