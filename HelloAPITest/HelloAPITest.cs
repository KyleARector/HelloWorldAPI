using System;
using HelloAPI;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HelloAPITest
{
    [TestClass]
    public class HelloAPIConsoleTest
    {
        [TestMethod]
        public void TestInstantiateConsole()
        {
            HelloAPIConsole console = new HelloAPIConsole();

            console.SetMessage("This is a message");

            Assert.AreEqual("This is a message", console.Message);
        }

        [TestMethod]
        public void TestInstantiateConsoleSecondConstructor()
        {
            HelloAPIConsole console = new HelloAPIConsole("This is a new message");

            Assert.AreEqual("This is a new message", console.Message);
        }

        [TestMethod]
        public void TestConsoleChangeMessage()
        {
            HelloAPIConsole console = new HelloAPIConsole("This is the old message");

            console.SetMessage("This is a new message");

            Assert.AreEqual("This is a new message", console.Message);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Message can not be null nor empty")]
        public void TestConsoleChangeMessageFail()
        {
            HelloAPIConsole console = new HelloAPIConsole();

            console.SetMessage("");
        }
    }

    [TestClass]
    public class HelloAPIMobileTest
    {
        [TestMethod]
        public void TestInstantiateMobile()
        {
            HelloAPIMobile mobile = new HelloAPIMobile();

            mobile.SetMessage("This is a mobile class");

            Assert.AreEqual("This is a mobile class", mobile.Message);
        }
    }

    [TestClass]
    public class HelloAPIDesktopTest
    {
        [TestMethod]
        public void TestInstantiateMobile()
        {
            HelloAPIDesktop desktop = new HelloAPIDesktop();

            desktop.SetMessage("This is a desktop class");

            Assert.AreEqual("This is a desktop class", desktop.Message);
        }
    }

    [TestClass]
    public class HelloAPIDatabaseTest
    {
        [TestMethod]
        public void TestInstantiateDatabase()
        {
            HelloAPIDatabase db = new HelloAPIDatabase();

            db.SetMessage("This is a database class");

            Assert.AreEqual("This is a database class", db.Message);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Database connection string can not be null nor empty")]
        public void TestDatabaseConnStringFail()
        {
            HelloAPIDatabase db = new HelloAPIDatabase();

            db.Init("");
        }
    }
}
