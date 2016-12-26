using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALTestProject
{
    /// <summary>
    /// 一个需要手工Commit，支持同步/异步操作和Dispose的Repository，
    /// </summary>
    interface IOrderClientRepository
    {
        Task<List<OrderClient>> GetAllClientsAsync();

        List<OrderClient> GetAllClients();

        void AddClient(OrderClient client);

        void DeleteClient(int ClientID);

        void ModifyClient(OrderClient client);
    }
}
