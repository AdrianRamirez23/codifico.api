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
    public class EmployBS: IEmployBS
    {
        private readonly IEmploySV employSV;
        public EmployBS(IEmploySV employ)
        {
            employSV = employ;
        }
        public List<Employ> GetEmployees() 
        {
            return employSV.GetEmployees();
        }
    }
}
