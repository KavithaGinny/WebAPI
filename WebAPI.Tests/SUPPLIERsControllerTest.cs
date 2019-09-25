using System.Web.Http;
using System.Linq;
using WebAPI.Models;
// <copyright file="SUPPLIERsControllerTest.cs">Copyright ©  2019</copyright>

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebAPI.Controllers;

namespace WebAPI.Controllers.Tests
{
    [TestClass]
    [PexClass(typeof(SUPPLIERsController))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class SUPPLIERsControllerTest
    {

        [PexMethod]
        public IQueryable<SUPPLIER> GetSUPPLIERs([PexAssumeUnderTest]SUPPLIERsController target)
        {
            IQueryable<SUPPLIER> result = target.GetSUPPLIERs();
            return result;
            // TODO: add assertions to method SUPPLIERsControllerTest.GetSUPPLIERs(SUPPLIERsController)
        }

        /// <summary>Test stub for GetSUPPLIER(String)</summary>
        [PexMethod]
        public IHttpActionResult GetSUPPLIERTest([PexAssumeUnderTest]SUPPLIERsController target, string id)
        {
            IHttpActionResult result = target.GetSUPPLIER(id);
            return result;
            // TODO: add assertions to method SUPPLIERsControllerTest.GetSUPPLIERTest(SUPPLIERsController, String)
        }

        [PexMethod]
        public IHttpActionResult PutSUPPLIER(
            [PexAssumeUnderTest]SUPPLIERsController target,
            string id,
            SUPPLIER sUPPLIER
        )
        {
            IHttpActionResult result = target.PutSUPPLIER(id, sUPPLIER);
            return result;
            // TODO: add assertions to method SUPPLIERsControllerTest.PutSUPPLIER(SUPPLIERsController, String, SUPPLIER)
        }

        [PexMethod]
        public IHttpActionResult PostSUPPLIER([PexAssumeUnderTest]SUPPLIERsController target, SUPPLIER sUPPLIER)
        {
            IHttpActionResult result = target.PostSUPPLIER(sUPPLIER);
            return result;
            // TODO: add assertions to method SUPPLIERsControllerTest.PostSUPPLIER(SUPPLIERsController, SUPPLIER)
        }

        [PexMethod]
        public IHttpActionResult DeleteSUPPLIER([PexAssumeUnderTest]SUPPLIERsController target, string id)
        {
            IHttpActionResult result = target.DeleteSUPPLIER(id);
            return result;
            // TODO: add assertions to method SUPPLIERsControllerTest.DeleteSUPPLIER(SUPPLIERsController, String)
        }
        
    }
}
