﻿using System;
using Dev2.Common;
using Dev2.Communication;
using Dev2.DynamicServices;
using Dev2.DynamicServices.Objects;
using Dev2.Interfaces;
using Dev2.Runtime.Hosting;
using Dev2.Workspaces;
using System.Collections.Generic;
using System.Text;

namespace Dev2.Runtime.ESB.Management.Services
{
    public class FetchExplorerItems : IEsbManagementEndpoint
    {
        private IExplorerServerResourceRepository _serverExplorerRepository;

        public string HandlesType()
        {
            return "FetchExplorerItemsService";
        }

        public StringBuilder Execute(Dictionary<string, StringBuilder> values, IWorkspace theWorkspace)
        {

            var serializer = new Dev2JsonSerializer();
            try
            {
                if(values == null)
                {
                    throw new ArgumentNullException("values");
                }
                var item = ServerExplorerRepo.Load(GlobalConstants.ServerWorkspaceID);
                return serializer.SerializeToBuilder(item);
            }
            catch(Exception e)
            {
                IExplorerRepositoryResult error = new ExplorerRepositoryResult(ExecStatus.Fail, e.Message);
                return serializer.SerializeToBuilder(error);
            }
        }

        public DynamicService CreateServiceEntry()
        {
            var findServices = new DynamicService { Name = HandlesType(), DataListSpecification = "<DataList><ResourceType ColumnIODirection=\"Input\"/><Roles ColumnIODirection=\"Input\"/><ResourceName ColumnIODirection=\"Input\"/><Dev2System.ManagmentServicePayload ColumnIODirection=\"Both\"></Dev2System.ManagmentServicePayload></DataList>" };

            var fetchItemsAction = new ServiceAction { Name = HandlesType(), ActionType = enActionType.InvokeManagementDynamicService, SourceMethod = HandlesType() };

            findServices.Actions.Add(fetchItemsAction);

            return findServices;
        }

        public IExplorerServerResourceRepository ServerExplorerRepo
        {
            get { return _serverExplorerRepository ?? ServerExplorerRepository.Instance; }
            set { _serverExplorerRepository = value; }
        }
    }
}
