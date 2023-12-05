using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Day.UnitTests
{
    [TestClass]
    public class OrderProcessorTest


    {

        [TestMethod]
        public void Process_OrderIsAlreadyShipped_ThrowAnExceprtion()

        {
            var orderProcessor = new OrderProcessor();
            
        }
        public class FakeShippingCalculator : IShippingCalculator
        {
            public float CalculateShipping(Order order)
            {
                throw new NotImplementedException();
            }
        }
    }
}
