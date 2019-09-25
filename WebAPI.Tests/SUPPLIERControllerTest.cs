using WebAPI.Models;
using System.Threading.Tasks;
using System.Web.Mvc;
// <copyright file="SUPPLIERControllerTest.cs">Copyright ©  2019</copyright>

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebAPI.Controllers;

namespace WebAPI.Controllers.Tests
{
    [TestClass]
    [PexClass(typeof(SUPPLIERController))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class SUPPLIERControllerTest
    {

        [PexMethod]
        public Task<ActionResult> Index([PexAssumeUnderTest]SUPPLIERController target)
        {
            Task<ActionResult> result = target.Index();
            return result;
            // TODO: add assertions to method SUPPLIERControllerTest.Index(SUPPLIERController)
        }

        [PexMethod]
        public Task<ActionResult> EditSupplier([PexAssumeUnderTest]SUPPLIERController target, string Id)
        {
            Task<ActionResult> result = target.EditSupplier(Id);
            return result;
            // TODO: add assertions to method SUPPLIERControllerTest.EditSupplier(SUPPLIERController, String)
        }

        [PexMethod]
        public Task<ActionResult> CreateSupplier([PexAssumeUnderTest]SUPPLIERController target, SUPPLIER i)
        {
            Task<ActionResult> result = target.CreateSupplier(i);
            return result;
            // TODO: add assertions to method SUPPLIERControllerTest.CreateSupplier(SUPPLIERController, SUPPLIER)
        }

        [PexMethod]
        public Task<ActionResult> EditSupplier_Post([PexAssumeUnderTest]SUPPLIERController target, SUPPLIER i)
        {
            Task<ActionResult> result = target.EditSupplier_Post(i);
            return result;
            // TODO: add assertions to method SUPPLIERControllerTest.EditSupplier_Post(SUPPLIERController, SUPPLIER)
        }

        [PexMethod]
        public Task<ActionResult> DetailsSupplier([PexAssumeUnderTest]SUPPLIERController target, string Id)
        {
            Task<ActionResult> result = target.DetailsSupplier(Id);
            return result;
            // TODO: add assertions to method SUPPLIERControllerTest.DetailsSupplier(SUPPLIERController, String)
        }

        [PexMethod]
        public Task<ActionResult> DeleteSupplier([PexAssumeUnderTest]SUPPLIERController target, string Id)
        {
            Task<ActionResult> result = target.DeleteSupplier(Id);
            return result;
            // TODO: add assertions to method SUPPLIERControllerTest.DeleteSupplier(SUPPLIERController, String)
        }
    }
}
