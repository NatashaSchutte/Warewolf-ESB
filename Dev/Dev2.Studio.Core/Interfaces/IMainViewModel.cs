﻿using System.Windows.Input;
using Dev2.Security;
using Dev2.Studio.Core.Interfaces;

namespace Dev2.Interfaces
{
    public interface IMainViewModel
    {
        ICommand DeployCommand { get; }
        ICommand ExitCommand { get; }
        AuthorizeCommand<string> NewResourceCommand { get; }
        IEnvironmentModel ActiveEnvironment { get; set; }
        IContextualResourceModel DeployResource { get; set; }
        void SetActiveEnvironment(IEnvironmentModel activeEnvironment);
        bool IsWorkFlowOpened(IContextualResourceModel resource);
        void UpdateWorkflowLink(IContextualResourceModel resource, string newPath, string oldPath);
        void ClearToolboxSelection();
    }
}
