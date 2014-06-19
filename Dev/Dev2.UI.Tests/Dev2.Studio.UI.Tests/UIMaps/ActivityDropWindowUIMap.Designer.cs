﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 11.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

using System.Linq;

namespace Dev2.Studio.UI.Tests.UIMaps.ActivityDropWindowUIMapClasses
{
    using System.CodeDom.Compiler;
    using System.Drawing;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;


    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public partial class ActivityDropWindowUIMap : UIMapBase
    {

        /// <summary>
        /// ClickOkButton
        /// </summary>
        public void ClickOkButton()
        {
            // Click 'OK' button
            Mouse.Click(GetOkButtonOnActivityDropWindow(), new Point(79, 11));
        }

        /// <summary>
        /// ClickCancelButton
        /// </summary>
        public void ClickCancelButton()
        {
            WpfButton uICancelButton = null;
            foreach(var child in StudioWindow.GetChildren()[0].GetChildren())
            {
                if(child.FriendlyName == "Cancel")
                {
                    uICancelButton = child as WpfButton;
                    break;
                }
            }

            // Click 'Cancel' button
            Mouse.Click(uICancelButton, new Point(64, 7));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public UITestControl GetOkButtonOnActivityDropWindow()
        {
            foreach(var child in StudioWindow.GetChildren()[0].GetChildren())
            {
                if(child.FriendlyName == "OK")
                {
                    return child as WpfButton;
                }
            }
            return null;
        }

        public bool IsOkButtonEnabled()
        {
            return GetOkButtonOnActivityDropWindow().Enabled;
        }

        

        private UITestControl GetLocalHostExplorerTree()
        {
            var SelectActivityDialog = StudioWindow.GetChildren()[0];
            foreach(var child in SelectActivityDialog.GetChildren())
            {
                var navViewAutoID = child.GetProperty("AutomationID").ToString();
                if(navViewAutoID.Contains("TheNavigationView"))
                {
                    foreach(var navigationViewChid in child.GetChildren())
                    {
                        var navAutoID = navigationViewChid.GetProperty("AutomationID").ToString();
                        if(navAutoID.Contains("Navigation"))
                        {
                            foreach(var navChild in navigationViewChid.GetChildren())
                            {
                                if(navChild.ControlType == ControlType.TreeItem)
                                {
                                    return navChild;
                                }
                            }
                        }
                    }
                }
            }
            throw new UITestControlNotFoundException("Localhost explorer tree not found, Activity Drop Window may not have openned yet.");
        }
        
        /// <summary>
        /// SingleClickAFolder
        /// </summary>
        public void SingleClickAFolder(string folderName)
        {
            var localHostExplorerTree = GetLocalHostExplorerTree();
            var resource = localHostExplorerTree.GetChildren()
                                 .First(i => i.GetProperty("AutomationID").ToString().Contains(folderName));

            if(resource == null)
            {
                throw new UITestControlNotFoundException("Resource not found");
            }

            Mouse.Click(resource, new Point(57, 9));
            Playback.Wait(100);
        }

        public void SingleClickResource(string folderName, string resourceName)
        {
            var localHostExplorerTree = GetLocalHostExplorerTree();

            var resource = localHostExplorerTree.GetChildren()
                                 .First(i => i.GetProperty("AutomationID").ToString().Contains(folderName))
                                 .GetChildren()
                                 .FirstOrDefault(i => i.GetProperty("AutomationID").ToString().Contains(resourceName));

            if(resource == null)
            {
                throw new UITestControlNotFoundException("Resource not found");
            }

            Mouse.Click(resource, new Point(57, 9));
            Playback.Wait(100);
        }

        /// <summary>
        /// DoubleClickAFolder
        /// </summary>
        public void DoubleClickFirstWorkflowFolder()
        {
            var localHostExplorerTree = GetLocalHostExplorerTree();
            foreach(var treeChild in localHostExplorerTree.GetChildren())
            {
                var workflowsAutoID = treeChild.GetProperty("AutomationID").ToString();
                if(workflowsAutoID.Contains("WORKFLOW"))
                {
                    UITestControlCollection uiTestControlCollection = treeChild.GetChildren();
                    UITestControl firstOrDefault = uiTestControlCollection.FirstOrDefault(c => c.ControlType == ControlType.TreeItem);

                    Mouse.Click(firstOrDefault, new Point(57, 9));
                    Playback.Wait(100);
                    Mouse.DoubleClick(firstOrDefault, new Point(57, 9));
                    return;
                }
            }
            throw new UITestControlNotFoundException("Folder not found");
        }

        public void SelectAResourceAndClickOk(string folderName, string resourceName)
        {
            var localHostExplorerTree = GetLocalHostExplorerTree();

            var resource = localHostExplorerTree.GetChildren()
                                 .First(i => i.GetProperty("AutomationID").ToString().Contains(folderName))
                                 .GetChildren()
                                 .FirstOrDefault(i => i.GetProperty("AutomationID").ToString().Contains(resourceName));

            if(resource == null)
            {
                throw new UITestControlNotFoundException("Resource not found");
            }

            Mouse.Click(resource, new Point(57, 9));
            Playback.Wait(100);

            ClickOkButton();
        }

    }
}
