﻿using Codifico.Models.RTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codifico.Bussiness.Interfaces
{
    public interface IClientsBS
    {
        List<Customer> SalesDatePrediction();
        List<ClientOrders> getClientsOrders(int id);
    }
}
