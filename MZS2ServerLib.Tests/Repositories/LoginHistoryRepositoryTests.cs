using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MZS2ServerLib.Tests.Repositories
{
    [TestClass]
    public class LoginHistoryRepositoryTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            LoginHistoryRepository.AddLoginHistory(1, "192.168.1.1");
        }
    }
}
