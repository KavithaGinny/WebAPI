using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using System.Web.Mvc;
using WebAPI.Controllers;
using Microsoft.Pex.Framework.Generated;
// <copyright file="SUPPLIERControllerTest.DeleteSupplier.g.cs">Copyright ©  2019</copyright>
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace WebAPI.Controllers.Tests
{
    public partial class SUPPLIERControllerTest
    {

[TestMethod]
[PexGeneratedBy(typeof(SUPPLIERControllerTest))]
public void DeleteSupplier470()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      SUPPLIERController sUPPLIERController;
      Task<ActionResult> task;
      sUPPLIERController = new SUPPLIERController();
      ((Controller)sUPPLIERController).Resolver = (IDependencyResolver)null;
      ((Controller)sUPPLIERController).ActionInvoker = (IActionInvoker)null;
      ((Controller)sUPPLIERController).TempDataProvider = (ITempDataProvider)null;
      ((Controller)sUPPLIERController).Url = (UrlHelper)null;
      ((Controller)sUPPLIERController).ViewEngineCollection =
        (ViewEngineCollection)null;
      ((ControllerBase)sUPPLIERController).ControllerContext =
        (ControllerContext)null;
      ((ControllerBase)sUPPLIERController).TempData = (TempDataDictionary)null;
      ((ControllerBase)sUPPLIERController).ValidateRequest = false;
      ((ControllerBase)sUPPLIERController).ValueProvider = (IValueProvider)null;
      ((ControllerBase)sUPPLIERController).ViewData = (ViewDataDictionary)null;      
      task = this.DeleteSupplier(sUPPLIERController, (string)null);     
      Assert.IsNotNull((object)task);
      Assert.AreEqual<TaskStatus>
          (TaskStatus.WaitingForActivation, ((Task)task).Status);
      Assert.AreEqual<bool>(false, ((Task)task).IsCanceled);
      Assert.IsNull(((Task)task).AsyncState);
      Assert.AreEqual<bool>(false, ((Task)task).IsFaulted);
      Assert.IsNotNull((object)sUPPLIERController);
      Assert.IsNotNull(((Controller)sUPPLIERController).AsyncManager);
      Assert.IsNotNull
          (((Controller)sUPPLIERController).AsyncManager.OutstandingOperations);
      Assert.IsNotNull(((Controller)sUPPLIERController).AsyncManager.Parameters);
      Assert.AreEqual<int>
          (45000, ((Controller)sUPPLIERController).AsyncManager.Timeout);
      Assert.IsNull(((Controller)sUPPLIERController).Url);
      Assert.IsNull(((ControllerBase)sUPPLIERController).ControllerContext);
      Assert.AreEqual<bool>
          (false, ((ControllerBase)sUPPLIERController).ValidateRequest);
    }
}
    }
}
