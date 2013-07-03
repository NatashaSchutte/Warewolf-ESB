﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 11.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

using System.Text;
using System.Threading;
using Dev2.CodedUI.Tests;
using Dev2.CodedUI.Tests.UIMaps.DocManagerUIMapClasses;
using Dev2.CodedUI.Tests.UIMaps.ExplorerUIMapClasses;
using Dev2.CodedUI.Tests.UIMaps.RibbonUIMapClasses;

namespace Dev2.Studio.UI.Tests.UIMaps.WebServiceWizardUIMapClasses
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Text.RegularExpressions;
    using System.Windows.Input;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;

    public partial class WebServiceWizardUIMap
    {
        public static void InitializeFullTestServiceAndSource(string serviceName, string sourceName)
        {
            //init
            var _docManager = new DocManagerUIMap();
            var _explorer = new ExplorerUIMap();

            //Open Web Source Wizard
            _docManager.ClickOpenTabPage("Explorer");
            var getLocalServer = _explorer.GetLocalServer();
            Mouse.Click(MouseButtons.Right, ModifierKeys.None, new Point(getLocalServer.BoundingRectangle.X, getLocalServer.BoundingRectangle.Y));
            for (var i = 0; i < 9; i++)
            {
                Keyboard.SendKeys("{DOWN}");
            }
            Keyboard.SendKeys("{ENTER}");
            Thread.Sleep(1000);

            //Web Source Details
            Keyboard.SendKeys("{TAB}http://www.webservicex.net/globalweather.asmx{TAB}{TAB}{TAB}{TAB}{ENTER}");
            Keyboard.SendKeys("{TAB}{TAB}{TAB}" + sourceName + "{TAB}{ENTER}");

            //Open Web Service Wizard
            _docManager.ClickOpenTabPage("Explorer");
            getLocalServer = _explorer.GetLocalServer();
            Mouse.Click(MouseButtons.Right, ModifierKeys.None, new Point(getLocalServer.BoundingRectangle.X, getLocalServer.BoundingRectangle.Y));
            for (var i = 0; i < 5; i++)
            {
                Keyboard.SendKeys("{DOWN}");
            }
            Keyboard.SendKeys("{ENTER}");
            Thread.Sleep(1000);

            //Web Service Details
            Keyboard.SendKeys("{TAB}{TAB}{DOWN}{TAB}{TAB}{TAB}{TAB}{TAB}{TAB}{ENTER}");
            Thread.Sleep(3000);//wait for test
            Keyboard.SendKeys("{TAB}{ENTER}");
            Thread.Sleep(1000);
            Keyboard.SendKeys(sourceName+"{ENTER}");
            Thread.Sleep(1000);
            Keyboard.SendKeys("{TAB}{TAB}{TAB}" + serviceName + "{TAB}{ENTER}");
            Thread.Sleep(1000);
            Keyboard.SendKeys("{TAB}{ENTER}");
            
        }

        public static void Cancel()
        {
            for (var i = 0; i < 4; i++)
            {
                Keyboard.SendKeys("{TAB}");
            }
            Keyboard.SendKeys("{ENTER}");
        }
    }

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIStartPageCustom : WpfCustom
    {
        
        public UIStartPageCustom(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "Uia.ContentPane";
            this.SearchProperties["AutomationId"] = "splurt";
            this.WindowTitles.Add(TestBase.GetStudioWindowName());
            #endregion
        }
        
        #region Properties
        public WpfImage UIItemImage
        {
            get
            {
                if ((this.mUIItemImage == null))
                {
                    this.mUIItemImage = new WpfImage(this);
                    #region Search Criteria
                    this.mUIItemImage.WindowTitles.Add(TestBase.GetStudioWindowName());
                    #endregion
                }
                return this.mUIItemImage;
            }
        }
        #endregion
        
        #region Fields
        private WpfImage mUIItemImage;
        #endregion
    }
}
