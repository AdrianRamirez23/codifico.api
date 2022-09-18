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
    public class ClientsBS: IClientsBS
    {
        private readonly IClientsSV _clients;

        public ClientsBS(IClientsSV clients)
        {
            _clients = clients;
        }
        public List<Customer> SalesDatePrediction() 
        {
            return _clients.SalesDatePrediction();
        }
        public List<ClientOrders> getClientsOrders(int id) 
        {
            return _clients.getClientsOrders(id);
        }
    }
}
