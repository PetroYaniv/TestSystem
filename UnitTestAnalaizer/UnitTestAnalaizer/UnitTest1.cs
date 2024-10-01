using System;
using AnalaizerClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data;
using System.Reflection;
using System.Diagnostics.Eventing.Reader;


namespace UnitTest1
{
    [TestClass]
    public class UnitTest1
    {
        public Type ClonClass = typeof(AnalaizerClass);
       

        public TestContext TestContext { get; set; }
        
        [DataSource("System.Data.SqlClient", @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Lab1SqlTestServer.mdf;Integrated Security=True;Connect Timeout=30", "TableTestDelimetr", DataAccessMethod.Sequential)]

        [TestMethod]
        public void Test_IsDelimetr_DB()
        {
            //Arrange
            char c = (char)Convert.ToChar(TestContext.DataRow["Symbol"]);
           
           
            //Expected
            bool expected = (bool)TestContext.DataRow["Expect"];
            //Actual
            
                var PrMet = Activator.CreateInstance(typeof(AnalaizerClass));
                MethodInfo method = ClonClass.GetMethod("IsDelimetr",
                BindingFlags.NonPublic | BindingFlags.Instance);
            if (PrMet == null)
            {
                object actual = new object[] { Convert.ToBoolean(method.Invoke(PrMet, new object[] { c })) };

                Assert.AreEqual(expected, actual);
            }
            else
            {
               
            }
             
        }
       

        [DataSource("System.Data.SqlClient", @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Lab1SqlTestServer.mdf;Integrated Security=True;Connect Timeout=30", "TableTestOperator", DataAccessMethod.Sequential)]

        [TestMethod]
        public void Test_IsOperator_DB()
        {
            //Arrange
            string d = (string)TestContext.DataRow["Operator"];

            //Expected
            bool expected = (bool)TestContext.DataRow["Expect"];
            //Actual
            bool actual = AnalaizerClass.IsOperator(d);
            Assert.AreEqual(expected, actual);


        }



    }
}