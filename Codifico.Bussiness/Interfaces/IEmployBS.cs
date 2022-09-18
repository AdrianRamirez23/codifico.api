using Codifico.Models.RTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codifico.Bussiness.Interfaces
{
    public interface IEmployBS
    {
        List<Employ> GetEmployees();
    }
}
