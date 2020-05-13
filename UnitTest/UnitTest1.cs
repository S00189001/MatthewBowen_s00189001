using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MatthewBowen_s00189001;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_IncreasePrice()
        {
            // Price is 100
            //ARRANGE
            Phone p1 = new Phone();
            
            decimal expectedPrice = 200m;
            //ACT
            p1.IncreasePrice(100);

            //ASSERT
            Assert.AreEqual(expectedPrice, p1.Price);
        }
    }
}
