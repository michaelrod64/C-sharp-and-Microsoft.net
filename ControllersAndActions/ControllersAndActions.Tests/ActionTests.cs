using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ControllersAndActions.Controllers;
using System.Web.Mvc;

namespace ControllersAndActions.Tests
{
    [TestClass]
    public class ActionTests
    {
        [TestMethod]
        public void ViewSelectionTest()
        {
            ExampleController target = new ExampleController();

            ViewResult result = target.Index();

            Assert.AreEqual("Homepage", result.ViewName);
        }

        [TestMethod]
        public void ViewSelectionTest()
        {
            ExampleController target = new ExampleController();

            ViewResult result = target.Index();

            Assert.AreEqual("Hello, World", result.ViewBag.Message);  
        }
        [TestMethod]
        public void RedirectTest()
        {
            ExampleController target = new ExampleController();

            RedirectResult result = target.Redirect();

            Assert.IsFalse(result.Permanent);
            Assert.AreEqual("/Example/Index", result.Url);
        }
        [TestMethod]
        public void RedirectValueTest(){
            ExampleController target = new ExampleController();

            RedirectToRouteResult result = target.Redirect();

            Assert.IsFalse(result.Permanent);

            Assert.AreEqual("Example", result.RouteValues["controller"]);
            Assert.AreEqual("Index", result.RouteValues["action"]);
            Assert.AreEqual("MyID", result.RouteValues["ID"]);
        }

        [TestMethod]
        public void StatusCodeResultTest()
        {
            ExampleController target = new ExampleController();

            HttpStatusCodeResult result = target.StatusCode();

            Assert.AreEqual(401, result.StatusCode);
        }
       

        
    }
}
