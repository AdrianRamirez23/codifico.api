using Codifico.Bussiness.Interfaces;
using Codifico.Models.RTO;
using Codifico.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codifico.Bussiness.Bussiness
{
    public class ShipperBS: IShipperBS
    {
        private readonly IShipperSV _shipper;
        public ShipperBS(IShipperSV shipper)
        {
            _shipper = shipper;
        }
        public List<Shippers> GetShippers()
        {
            return _shipper.GetShippers();
        }
    }
}
