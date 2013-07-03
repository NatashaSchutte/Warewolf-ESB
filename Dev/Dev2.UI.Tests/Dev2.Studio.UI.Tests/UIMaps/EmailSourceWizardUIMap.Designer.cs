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

namespace Dev2.Studio.UI.Tests.UIMaps.EmailSourceWizardUIMapClasses
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

    public partial class EmailSourceWizardUIMap
    {

        public static void InitializeFullTestSource(string name)
        {
            new DocManagerUIMap().ClickOpenTabPage("Explorer");

            var getLocalServer = new ExplorerUIMap().GetLocalServer();
            Mouse.Click(MouseButtons.Right, ModifierKeys.None, new Point(getLocalServer.BoundingRectangle.X, getLocalServer.BoundingRectangle.Y));
            for (var i = 0; i < 10; i++)
            {
                Keyboard.SendKeys("{DOWN}");
            }
            Keyboard.SendKeys("{ENTER}");
            Thread.Sleep(1000);

            StringBuilder buildCommand = new StringBuilder();
            buildCommand.Append("{TAB}smtp.afrihost.co.za{TAB}");
            buildCommand.Append("dev2test{TAB}");
            buildCommand.Append("Password{TAB}{TAB}");
            buildCommand.Append("{TAB}{TAB}{ENTER}");
            buildCommand.Append("^AThorLocal@norsegods.com{TAB}");
            buildCommand.Append("dev2warewolf@gmail.com{TAB}{TAB}");
            buildCommand.Append("{ENTER}");
            Keyboard.SendKeys(buildCommand.ToString());
            buildCommand.Clear();

            Thread.Sleep(10000);
            for (var i = 0; i < 8; i++)
            {
                buildCommand.Append("{TAB}");
            }
            buildCommand.Append("{ENTER}");
            Keyboard.SendKeys(buildCommand.ToString());
            buildCommand.Clear();

            buildCommand.Append("{TAB}{TAB}{TAB}" + name + "{TAB}{ENTER}");
            Keyboard.SendKeys(buildCommand.ToString());
            buildCommand.Clear();
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
