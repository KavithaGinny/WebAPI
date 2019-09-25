using System.Web.Http;
// <copyright file="ITEMsControllerTest.cs">Copyright ©  2019</copyright>
using System;
using System.Linq;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebAPI.Controllers;
using WebAPI.Models;
using Microsoft.Pex.Framework.Generated;
using System.Net.Http;
using System.Net;
using System.Web.Http.Results;

namespace WebAPI.Controllers.Tests
{
    /// <summary>This class contains parameterized unit tests for ITEMsController</summary>
    [PexClass(typeof(ITEMsController))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class ITEMsControllerTest
    {
        /// <summary>Test stub for GetITEMs()</summary>
        [PexMethod(MaxBranches = 20000)]
        public IQueryable<ITEM> GetITEMsTest([PexAssumeUnderTest]ITEMsController target)
        {
            IQueryable<ITEM> result = target.GetITEMs();

            return result;
            // TODO: add assertions to method ITEMsControllerTest.GetITEMsTest(ITEMsController)
        }

        [PexMethod]
        public IHttpActionResult GetITEM([PexAssumeUnderTest]ITEMsController target, string id)
        {
            IHttpActionResult result = target.GetITEM(id);
            return result;
            // TODO: add assertions to method ITEMsControllerTest.GetITEM(ITEMsController, String)
        }
        [TestMethod]
        [PexGeneratedBy(typeof(ITEMsControllerTest))]
        [PexDescription("the test state was: path bounds exceeded")]
        public void GetITEM01()
        {
            using (PexDisposableContext disposables = PexDisposableContext.Create())
            {
                ITEMsController iTEMsController;
                IHttpActionResult iHttpActionResult;
                iTEMsController = new ITEMsController();
                iHttpActionResult = this.GetITEM(iTEMsController, "100");
                Assert.IsNotNull((object)iHttpActionResult);
            }
        }
        [TestMethod]
        public void PostRequest()
        {
            var controller = new ITEMsController();
            controller.Request = new HttpRequestMessage();
            controller.Configuration = new HttpConfiguration();


            var response = controller.PostITEM(new ITEM { ITCODE = "191", ITDESC = "Collgate", ITRATE = 80 });            

            Assert.IsNotNull(response);            

        }

        [PexMethod]
        public IHttpActionResult PutITEM(
            [PexAssumeUnderTest]ITEMsController target,
            string id,
            ITEM iTEM
        )
        {
            IHttpActionResult result = target.PutITEM(id, iTEM);
            return result;
            // TODO: add assertions to method ITEMsControllerTest.PutITEM(ITEMsController, String, ITEM)
        }

        [PexMethod]
        public IHttpActionResult DeleteITEM([PexAssumeUnderTest]ITEMsController target, string id)
        {
            IHttpActionResult result = target.DeleteITEM(id);
            return result;
            // TODO: add assertions to method ITEMsControllerTest.DeleteITEM(ITEMsController, String)
        }
    }
}
