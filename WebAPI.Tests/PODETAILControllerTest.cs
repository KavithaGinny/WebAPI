using WebAPI.Models;
using System.Threading.Tasks;
using System.Web.Mvc;
// <copyright file="PODETAILControllerTest.cs">Copyright ©  2019</copyright>

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebAPI.Controllers;

namespace WebAPI.Controllers.Tests
{
    [TestClass]
    [PexClass(typeof(PODETAILController))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class PODETAILControllerTest
    {

        [PexMethod]
        public Task<ActionResult> Index([PexAssumeUnderTest]PODETAILController target)
        {
            Task<ActionResult> result = target.Index();
            return result;
            // TODO: add assertions to method PODETAILControllerTest.Index(PODETAILController)
        }

        [PexMethod]
        public Task<ActionResult> EditPoDetail(
            [PexAssumeUnderTest]PODETAILController target,
            string Id,
            string itcode
        )
        {
            Task<ActionResult> result = target.EditPoDetail(Id, itcode);
            return result;
            // TODO: add assertions to method PODETAILControllerTest.EditPoDetail(PODETAILController, String, String)
        }

        [PexMethod]
        public ActionResult CreatePoDetail([PexAssumeUnderTest]PODETAILController target)
        {
            ActionResult result = target.CreatePoDetail();
            return result;
            // TODO: add assertions to method PODETAILControllerTest.CreatePoDetail(PODETAILController)
        }

        [PexMethod]
        public Task<ActionResult> EditPoDetail_Post([PexAssumeUnderTest]PODETAILController target, PODETAIL i)
        {
            Task<ActionResult> result = target.EditPoDetail_Post(i);
            return result;
            // TODO: add assertions to method PODETAILControllerTest.EditPoDetail_Post(PODETAILController, PODETAIL)
        }

        [PexMethod]
        public Task<ActionResult> DetailsPoDetail([PexAssumeUnderTest]PODETAILController target, string Id)
        {
            Task<ActionResult> result = target.DetailsPoDetail(Id);
            return result;
            // TODO: add assertions to method PODETAILControllerTest.DetailsPoDetail(PODETAILController, String)
        }
    }
}
