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

        


    }
}
