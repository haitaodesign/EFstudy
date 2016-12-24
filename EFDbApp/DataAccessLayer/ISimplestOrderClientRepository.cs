using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DataAccessLayer
{
    /// <summary>
    /// 实现最简单CRUD接口，具体的操作类实现此接口
    /// </summary>
    public interface ISimplestOrderClientRepository
    {
        List<OrderClient> GetAllClients();

        List<OrderClient> FindClientsByName(String FindWhat);

        int AddClient(OrderClient client);

        int DeleteClient(OrderClient ClientID);

        int ModifyClient(OrderClient client);
    }
}
