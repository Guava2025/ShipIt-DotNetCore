
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace ShipIt.Models.ApiModels
{
    public class OutboundOrderResponse
    {
        public int WarehouseId { get; set; }
        
        public float OrderWeight { get; set; }

        public int TrucksRequired { get; set; }
        
        public override string ToString()
        {
            return $"Response: {WarehouseId} {OrderWeight} {TrucksRequired}";
        }

    }
}
