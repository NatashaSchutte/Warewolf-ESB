﻿using System;
using Dev2.Activities;
using Dev2.DataList.Contract;
using Dev2.DynamicServices;
using Dev2.Services.Execution;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Moq.Protected;

namespace Dev2.Tests.Activities.ActivityTests
{
    [TestClass]
    public class DsfPluginActivityTests
    {
        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext { get; set; }

        #region Plugin Service Execution

        [TestMethod]
        [TestCategory("UnitTest")]
        [Description("Test 'GetNewPluginServiceExecution' for 'DsfPluginActivity': A valid plugin service execution is constructed by DsfPluginActivity")]
        [Owner("Ashley Lewis")]
        // ReSharper disable InconsistentNaming
        public void DsfPluginActivity_DsfPluginActivityUnitTest_GetNewPluginServiceExecution_ServiceConstructed()
        // ReSharper restore InconsistentNaming
        {
            //init
            var expected = Guid.NewGuid();
            var pluginActivity = new MockDsfPluginActivity();
            var mockContext = new DsfDataObject("<DataList></DataList>", expected);

            //exe
            var actual = pluginActivity.MockGetNewPluginServiceExecution(mockContext);

            //assert
            Assert.AreEqual(typeof(PluginServiceExecution), actual.GetType(), "DsfPluginActivity did not construct a correct PluginServiceExecution");
            Assert.AreEqual(expected, actual.DataObj.DataListID, "The Plugin Service Execution constructed by DsfPluginActivity is using the incorrect datalist");
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [Description("Test for Execution of 'PluginServiceExecution': A valid plugin service is executed")]
        [Owner("Ashley Lewis")]
        // ReSharper disable InconsistentNaming
        public void DsfPluginActivity_DsfPluginActivityUnitTest_ExecutePluginService_ServiceExecuted()
        // ReSharper restore InconsistentNaming
        {
            //init
            var pluginActivity = new MockDsfPluginActivity();
            var errors = new ErrorResultTO();
            var mockContainer = new Mock<PluginServiceExecution>(new DsfDataObject(It.IsAny<string>(), It.IsAny<Guid>()), It.IsAny<bool>());
            mockContainer.Setup(c => c.Execute(out errors)).Verifiable();

            //exe
            pluginActivity.MockExecutePluginService(mockContainer.Object);

            //assert
            Assert.IsFalse(errors.HasErrors(), "Errors where thrown while executing a plugin service");
            mockContainer.Verify(c => c.Execute(out errors), Times.Once());
        }
        
        #endregion
    }
}
