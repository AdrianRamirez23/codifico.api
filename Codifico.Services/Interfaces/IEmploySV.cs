using Codifico.Models.RTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codifico.Services.Interfaces
{
    public interface IEmploySV
    {
        List<Employ> GetEmployees();
    }
}
