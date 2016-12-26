using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using Model;

namespace DALTestProject
{
    [TestClass]
    public class SimplestOrderClientRepositoryTest
    {
        ISimplestOrderClientRepository repo = null;

        [TestInitialize]
        public void TestInitialize()
        {
            repo = new SimplestOrderClientRepository();
        }

        [TestCleanup]
        public void TestCleanup()
        {
            //单元测试运行完之后不做任何操作
        }


        [TestMethod]
        public void TestGetAllClients()
        {
            List<OrderClient> Clients = repo.GetAllClients();
            Assert.IsTrue(Clients.Count() > 0);
        }

        [TestMethod]
        public void TestAddClient()
        {
            OrderClient client = OrderClientHelper.CreateOrderClient();
            int result= repo.AddClient(client);
            Assert.IsTrue(result == 1);
            String name = client.ClientName;

            //是否添加成功
            List<OrderClient> Clients = repo.GetAllClients();
            OrderClient client2= Clients.FirstOrDefault(c => c.ClientName == client.ClientName);
            Console.WriteLine(client2.ClientName);
        }

        [TestMethod]
        public void TestDeleteClient()
        {
            List<OrderClient> clients = repo.GetAllClients();
            int clientID = clients.Last().ClientID;
            Console.WriteLine("将要删除的用户ID"+clientID);
            int result = repo.DeleteClient(clientID);
            Assert.IsTrue(result == 1);

            //打印出删除信息的ClientID
            Console.WriteLine("已经删除的用户ID"+clients.Last().ClientID);
        }


    }
}
