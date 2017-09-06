using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CW.API;

namespace CW.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void WrongClassThrowsException()
        {
            var writer = WriterFactory.GetWriter("Test");
        }

        [TestMethod]
        public void WriterFactoryReturnsCorrectWriter()
        {
            var writer = WriterFactory.GetWriter("CW.API.ConsoleWriter,CW.API");
            Assert.IsInstanceOfType(writer, typeof(IWriter));
        }

        [TestMethod]
        public void ConsoleWriterWritesWOException()
        {
            var writer = WriterFactory.GetWriter("CW.API.ConsoleWriter,CW.API");
            try
            {
                writer.Write("test");
            }
            catch (Exception ex)
            {
                Assert.Fail("Expected no exception, but got: " + ex.Message);
            }
        }
    }
}
