using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codifico.Models.DTO
{
    public class OrderNew
    {
        public int CustID { get; set; }
        public int Empid { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime RequiredDate { get; set; }
        public DateTime Shippeddate { get; set; }
        public int ShipperId { get; set; }
        public float Freigth { get; set; }
        public string Shipname { get; set; }
        public string Shipaddress { get; set; }
        public string Shipcity { get; set; }
        public string Shiregion { get; set; }
        public string Shipppostalcode { get; set; }
        public string Shipcountry { get; set; }
        public int ProductId { get; set; }
        public float UnitPrice { get; set; }
        public Int16 qty { get; set; }
        public decimal discount { get; set; }

    }
}
