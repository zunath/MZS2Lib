using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MZS2ServerLib.Tests.Repositories
{
    [TestClass]
    public class PlayerCharacterRepositoryTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            PlayerCharacterRepository.SavePlayerCharacter(
                "1", "zunath", "12345678", "Char Name", "20", "areatag", "1.0", "1.5", "1.2", "30.0"
                );


        }
    }
}
