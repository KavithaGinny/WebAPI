using WebAPI.Models;
using System.Threading.Tasks;
using System.Web.Mvc;
// <copyright file="ITEMControllerTest.cs">Copyright ©  2019</copyright>

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebAPI.Controllers;
using Microsoft.Pex.Framework.Generated;

namespace WebAPI.Controllers.Tests
{
    [TestClass]
    [PexClass(typeof(ITEMController))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class ITEMControllerTest
    {

        [PexMethod]
        public Task<ActionResult> Index([PexAssumeUnderTest]ITEMController target)
        {
            Task<ActionResult> result = target.Index();
            Assert.IsNotNull(result);
            return result;
            // TODO: add assertions to method ITEMControllerTest.Index(ITEMController)
        }

        [PexMethod]
        public Task<ActionResult> EditItem([PexAssumeUnderTest]ITEMController target, string Id)
        {
            Task<ActionResult> result = target.EditItem(Id);
            Assert.IsNotNull(result);
            return result;
            // TODO: add assertions to method ITEMControllerTest.EditItem(ITEMController, String)
        }

        /// <summary>Test stub for CreateItem()</summary>
        [PexMethod]
        public ActionResult CreateItemTest([PexAssumeUnderTest]ITEMController target)
        {
            ActionResult result = target.CreateItem();
            Assert.IsNotNull(result);
            return result;
            // TODO: add assertions to method ITEMControllerTest.CreateItemTest(ITEMController)
        }
        [TestMethod]
        [PexGeneratedBy(typeof(ITEMControllerTest))]
        public void EditItem450()
        {
            using (PexDisposableContext disposables = PexDisposableContext.Create())
            {
                ITEMController iTEMController;
                Task<ActionResult> task;
                iTEMController = new ITEMController();
                ((Controller)iTEMController).Resolver = (IDependencyResolver)null;
                ((Controller)iTEMController).ActionInvoker = (IActionInvoker)null;
                ((Controller)iTEMController).TempDataProvider = (ITempDataProvider)null;
                ((Controller)iTEMController).Url = (UrlHelper)null;
                ((Controller)iTEMController).ViewEngineCollection = (ViewEngineCollection)null;
                ((ControllerBase)iTEMController).ControllerContext = (ControllerContext)null;
                ((ControllerBase)iTEMController).TempData = (TempDataDictionary)null;
                ((ControllerBase)iTEMController).ValidateRequest = false;
                ((ControllerBase)iTEMController).ValueProvider = (IValueProvider)null;
                ((ControllerBase)iTEMController).ViewData = (ViewDataDictionary)null;

                task = this.EditItem(iTEMController, "100");

                Assert.IsNotNull((object)task);
                Assert.AreEqual<TaskStatus>
                    (TaskStatus.WaitingForActivation, ((Task)task).Status);
                Assert.AreEqual<bool>(false, ((Task)task).IsCanceled);
                Assert.IsNull(((Task)task).AsyncState);
                Assert.AreEqual<bool>(false, ((Task)task).IsFaulted);
                Assert.IsNotNull((object)iTEMController);
                Assert.IsNotNull(((Controller)iTEMController).AsyncManager);
                Assert.IsNotNull
                    (((Controller)iTEMController).AsyncManager.OutstandingOperations);
                Assert.IsNotNull(((Controller)iTEMController).AsyncManager.Parameters);
                Assert.AreEqual<int>(45000, ((Controller)iTEMController).AsyncManager.Timeout);
                Assert.IsNull(((Controller)iTEMController).Url);
                Assert.IsNull(((ControllerBase)iTEMController).ControllerContext);
                Assert.AreEqual<bool>(false, ((ControllerBase)iTEMController).ValidateRequest);
            }
        }
        [TestMethod]
        [PexGeneratedBy(typeof(ITEMControllerTest))]
        public void Index183()
        {
            using (PexDisposableContext disposables = PexDisposableContext.Create())
            {
                ITEMController iTEMController;
                Task<ActionResult> task;
                iTEMController = new ITEMController();
                ((Controller)iTEMController).Resolver = (IDependencyResolver)null;
                ((Controller)iTEMController).ActionInvoker = (IActionInvoker)null;
                ((Controller)iTEMController).TempDataProvider = (ITempDataProvider)null;
                ((Controller)iTEMController).Url = (UrlHelper)null;
                ((Controller)iTEMController).ViewEngineCollection = (ViewEngineCollection)null;
                ((ControllerBase)iTEMController).ControllerContext = (ControllerContext)null;
                ((ControllerBase)iTEMController).TempData = (TempDataDictionary)null;
                ((ControllerBase)iTEMController).ValidateRequest = false;
                ((ControllerBase)iTEMController).ValueProvider = (IValueProvider)null;
                ((ControllerBase)iTEMController).ViewData = (ViewDataDictionary)null;
                task = this.Index(iTEMController);

                Assert.IsNotNull((object)iTEMController);

            }
        }

        [PexMethod]
        public Task<ActionResult> CreateItem([PexAssumeUnderTest]ITEMController target, ITEM i)
        {
            Task<ActionResult> result = target.CreateItem(i);
            return result;
            // TODO: add assertions to method ITEMControllerTest.CreateItem(ITEMController, ITEM)
        }

        [PexMethod]
        public Task<ActionResult> DetailsItem([PexAssumeUnderTest]ITEMController target, string Id)
        {
            Task<ActionResult> result = target.DetailsItem(Id);
            return result;
            // TODO: add assertions to method ITEMControllerTest.DetailsItem(ITEMController, String)
        }
    }
}
