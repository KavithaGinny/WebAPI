using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using System.Web.Mvc;
using WebAPI.Controllers;
using Microsoft.Pex.Framework.Generated;
// <copyright file="PODETAILControllerTest.Index.g.cs">Copyright ©  2019</copyright>
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
    public partial class PODETAILControllerTest
    {

[TestMethod]
[PexGeneratedBy(typeof(PODETAILControllerTest))]
public void Index448()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      PODETAILController pODETAILController;
      Task<ActionResult> task;
      pODETAILController = new PODETAILController();
      ((Controller)pODETAILController).Resolver = (IDependencyResolver)null;
      ((Controller)pODETAILController).ActionInvoker = (IActionInvoker)null;
      ((Controller)pODETAILController).TempDataProvider = (ITempDataProvider)null;
      ((Controller)pODETAILController).Url = (UrlHelper)null;
      ((Controller)pODETAILController).ViewEngineCollection =
        (ViewEngineCollection)null;
      ((ControllerBase)pODETAILController).ControllerContext =
        (ControllerContext)null;
      ((ControllerBase)pODETAILController).TempData = (TempDataDictionary)null;
      ((ControllerBase)pODETAILController).ValidateRequest = false;
      ((ControllerBase)pODETAILController).ValueProvider = (IValueProvider)null;
      ((ControllerBase)pODETAILController).ViewData = (ViewDataDictionary)null;      
      task = this.Index(pODETAILController);     
      Assert.IsNotNull((object)task);
      Assert.AreEqual<TaskStatus>
          (TaskStatus.WaitingForActivation, ((Task)task).Status);
      Assert.AreEqual<bool>(false, ((Task)task).IsCanceled);
      Assert.IsNull(((Task)task).AsyncState);
      Assert.AreEqual<bool>(false, ((Task)task).IsFaulted);
      Assert.IsNotNull((object)pODETAILController);
      Assert.IsNotNull(((Controller)pODETAILController).AsyncManager);
      Assert.IsNotNull
          (((Controller)pODETAILController).AsyncManager.OutstandingOperations);
      Assert.IsNotNull(((Controller)pODETAILController).AsyncManager.Parameters);
      Assert.AreEqual<int>
          (45000, ((Controller)pODETAILController).AsyncManager.Timeout);
      Assert.IsNull(((Controller)pODETAILController).Url);
      Assert.IsNull(((ControllerBase)pODETAILController).ControllerContext);
      Assert.AreEqual<bool>
          (false, ((ControllerBase)pODETAILController).ValidateRequest);
    }
}
    }
}
