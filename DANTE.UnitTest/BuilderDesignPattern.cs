using DesignPatterns.BusinessServices;
using DesignPatterns.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DANTE.UnitTest
{
    [TestClass]
    public class BuilderDesignPattern
    {
        [TestMethod]
        public void CreateMessage()
        {
            CreateMessageBuilder test = new CreateMessageBuilder();
            Message result = test.CreateMessage(new BirthdayMessageBuilder());
        }
    }
}
