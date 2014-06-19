﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Threading;
using Caliburn.Micro;
using Dev2.AppResources.Repositories;
using Dev2.Composition;
using Dev2.Core.Tests.Environments;
using Dev2.Core.Tests.Utils;
using Dev2.Models;
using Dev2.Services.Security;
using Dev2.Studio.Core;
using Dev2.Studio.Core.AppResources.Enums;
using Dev2.Studio.Core.Interfaces;
using Dev2.Studio.Deploy;
using Dev2.Studio.TO;
using Dev2.Studio.ViewModels.Deploy;
using Dev2.ViewModels.Deploy;
using Moq;

namespace Dev2.Core.Tests.Deploy
{
    public abstract class DeployViewModelTestBase
    {
        protected static ImportServiceContext OkayContext = new Mock<ImportServiceContext>().Object;
       static Action<System.Action, DispatcherPriority> _Invoke = new Action<System.Action, DispatcherPriority>((a, b) => { });
        #region Setup DeploymentViewModel
        protected static DeployStatsCalculator SetupDeployViewModel(out DeployViewModel deployViewModel)
        {
            var source = EnviromentRepositoryTest.CreateMockEnvironment();
            var destination = EnviromentRepositoryTest.CreateMockEnvironment();
            source.Setup(a => a.AuthorizationService).Returns(new Mock<IAuthorizationService>().Object);
            destination.Setup(a => a.AuthorizationService).Returns(new Mock<IAuthorizationService>().Object);
            var serverProvider = new Mock<IEnvironmentModelProvider>();
            serverProvider.Setup(s => s.Load()).Returns(new List<IEnvironmentModel> { source.Object, destination.Object });

            var repo = new TestEnvironmentRespository(source.Object, destination.Object);

            var deployStatsCalculator = new DeployStatsCalculator();
            ExplorerItemModel resourceVm;
            var studioResourceRepository = CreateModels(false, source.Object, out resourceVm);
          
            deployViewModel = new DeployViewModel(AsyncWorkerTests.CreateSynchronousAsyncWorker().Object, serverProvider.Object, repo, new Mock<IEventAggregator>().Object, studioResourceRepository, deployStatsCalculator)
            {
                SelectedSourceServer = source.Object,
                SelectedDestinationServer = destination.Object
            };
            return deployStatsCalculator;
        }
        #endregion


        protected static void SetupResources(DeployStatsCalculator deployStatsCalculator, bool isChecked)
        {
            IEnvironmentModel environmentModel;
            ExplorerItemModel resourceVm;
            var studioResourceRepository = CreateModels(isChecked, out environmentModel, out resourceVm);

            var navVm = new DeployNavigationViewModel(new Mock<IEventAggregator>().Object, AsyncWorkerTests.CreateSynchronousAsyncWorker().Object, new Mock<IEnvironmentRepository>().Object, studioResourceRepository,true);
            navVm.Environment = environmentModel;
            resourceVm.IsChecked = isChecked;
            deployStatsCalculator.DeploySummaryPredicateExisting(resourceVm, navVm);
        }

        protected static StudioResourceRepository CreateModels(bool isChecked, out IEnvironmentModel environmentModel, out ExplorerItemModel resourceVm)
        {
            Mock<IContextualResourceModel> resourceModel = Dev2MockFactory.SetupResourceModelMock(ResourceType.WorkflowService, Guid.NewGuid());

            var connection = new Mock<IEnvironmentConnection>();

            var mockEnvironmentModel = new Mock<IEnvironmentModel>();
            mockEnvironmentModel.Setup(e => e.Connection).Returns(connection.Object);
            var env  = Dev2MockFactory.SetupEnvironmentModel(resourceModel, new List<IResourceModel>());
            env.Setup(a => a.AuthorizationService).Returns(new Mock<IAuthorizationService>().Object);
            environmentModel = env.Object;
            var serverItemModel = new ExplorerItemModel();
            serverItemModel.DisplayName = "localhost";
            serverItemModel.ResourceType = Data.ServiceModel.ResourceType.Server;
            serverItemModel.EnvironmentId = environmentModel.ID;
            serverItemModel.ResourceId = Guid.NewGuid();
            serverItemModel.ResourcePath = "";

            ExplorerItemModel workflowsFolder = new ExplorerItemModel();
            workflowsFolder.DisplayName = "WORKFLOWS";
            workflowsFolder.ResourceType = Data.ServiceModel.ResourceType.Folder;
            workflowsFolder.ResourcePath = "WORKFLOWS";
            workflowsFolder.ResourceId = Guid.NewGuid();
            workflowsFolder.EnvironmentId = mockEnvironmentModel.Object.ID;

            serverItemModel.Children.Add(workflowsFolder);

            var studioResourceRepository = new StudioResourceRepository(serverItemModel, _Invoke);
            resourceModel.Setup(model => model.Category).Returns("WORKFLOWS\\" + resourceModel.Object.DisplayName);
            TestEnvironmentRespository testEnvironmentRespository = new TestEnvironmentRespository(environmentModel);
            new EnvironmentRepository(testEnvironmentRespository);
            IEnvironmentModel internalEnvironmentModel = environmentModel;
            studioResourceRepository.GetCurrentEnvironment = () => internalEnvironmentModel.ID;
            studioResourceRepository.AddResouceItem(resourceModel.Object);
            resourceVm = workflowsFolder.Children[0];
            resourceVm.IsChecked = isChecked;
            return studioResourceRepository;
        }

        protected static StudioResourceRepository CreateModels(bool isChecked, IEnvironmentModel environmentModel, out ExplorerItemModel resourceVm)
        {
            Mock<IContextualResourceModel> resourceModel = Dev2MockFactory.SetupResourceModelMock(ResourceType.WorkflowService, Guid.NewGuid());
            var serverItemModel = new ExplorerItemModel();
            serverItemModel.DisplayName = "localhost";
            serverItemModel.ResourceType = Data.ServiceModel.ResourceType.Server;
            serverItemModel.EnvironmentId = environmentModel.ID;
            serverItemModel.ResourceId = Guid.NewGuid();
            serverItemModel.ResourcePath = "";

            ExplorerItemModel workflowsFolder = new ExplorerItemModel();
            workflowsFolder.DisplayName = "WORKFLOWS";
            workflowsFolder.ResourceType = Data.ServiceModel.ResourceType.Folder;
            workflowsFolder.ResourcePath = "WORKFLOWS";
            workflowsFolder.ResourceId = Guid.NewGuid();
            workflowsFolder.EnvironmentId = environmentModel.ID;

            serverItemModel.Children.Add(workflowsFolder);

            var studioResourceRepository = new StudioResourceRepository(serverItemModel, _Invoke);
            resourceModel.Setup(model => model.Category).Returns("WORKFLOWS\\" + resourceModel.Object.DisplayName);
            TestEnvironmentRespository testEnvironmentRespository = new TestEnvironmentRespository(environmentModel);
            new EnvironmentRepository(testEnvironmentRespository);
            IEnvironmentModel internalEnvironmentModel = environmentModel;
            studioResourceRepository.GetCurrentEnvironment = () => internalEnvironmentModel.ID;
            studioResourceRepository.AddResouceItem(resourceModel.Object);
            resourceVm = workflowsFolder.Children[0];
            resourceVm.IsChecked = isChecked;
            return studioResourceRepository;
        }

        protected static DeployViewModel SetupDeployViewModel(out Mock<IEnvironmentModel> destEnv, out Mock<IEnvironmentModel> destServer)
        {
            ImportService.CurrentContext = OkayContext;

            var destConnection = new Mock<IEnvironmentConnection>();

            destEnv = new Mock<IEnvironmentModel>();
            destEnv.Setup(e => e.Connection).Returns(destConnection.Object);
            IAuthorizationService service = new Mock<IAuthorizationService>().Object;
            destEnv.Setup(a => a.AuthorizationService).Returns(service);
            destServer = destEnv;


            var envRepo = new Mock<IEnvironmentRepository>();
            envRepo.Setup(r => r.Fetch(It.IsAny<IEnvironmentModel>())).Returns(destEnv.Object);

            var servers = new List<IEnvironmentModel> { destEnv.Object };
            var serverProvider = new Mock<IEnvironmentModelProvider>();
            serverProvider.Setup(s => s.Load()).Returns(servers);

            // ReSharper disable once RedundantAssignment
            int deployItemCount;
            var statsCalc = new Mock<IDeployStatsCalculator>();
            statsCalc.Setup(c => c.CalculateStats(It.IsAny<IEnumerable<ExplorerItemModel>>(), It.IsAny<Dictionary<string, Func<ExplorerItemModel, bool>>>(), It.IsAny<ObservableCollection<DeployStatsTO>>(), out deployItemCount));
            var mockStudioResourceRepository = new Mock<IStudioResourceRepository>();
            mockStudioResourceRepository.Setup(repository => repository.Filter(It.IsAny<Func<ExplorerItemModel, bool>>())).Returns(new ObservableCollection<ExplorerItemModel>());
            var deployViewModel = new DeployViewModel(AsyncWorkerTests.CreateSynchronousAsyncWorker().Object, serverProvider.Object, envRepo.Object, new Mock<IEventAggregator>().Object, mockStudioResourceRepository.Object, statsCalc.Object);

            deployViewModel.Source.ExplorerItemModels = new ObservableCollection<ExplorerItemModel>();
            deployViewModel.Target.ExplorerItemModels = new ObservableCollection<ExplorerItemModel>();
            return deployViewModel;
        }

        #region CreateEnvironmentRepositoryMock

        protected static Guid SetupVmForMessages(out IEnvironmentModel server, out DeployViewModel vm, Mock<IEventAggregator> mockEventAggregator = null)
        {
            ImportService.CurrentContext = new Mock<ImportServiceContext>().Object;
            var env = EnviromentRepositoryTest.CreateMockEnvironment();
            var envID = env.Object.ID;
            server = env.Object;

            var serverProvider = new Mock<IEnvironmentModelProvider>();
            serverProvider.Setup(s => s.Load()).Returns(new List<IEnvironmentModel> { server });
            var repo = CreateEnvironmentRepositoryMock();
            if(mockEventAggregator == null)
            {
                mockEventAggregator = new Mock<IEventAggregator>();
            }
            var studioResourceRepository = new Mock<IStudioResourceRepository>();
            studioResourceRepository.Setup(repository => repository.Filter(It.IsAny<Func<ExplorerItemModel, bool>>())).Returns(new ObservableCollection<ExplorerItemModel>());
            vm = new DeployViewModel(AsyncWorkerTests.CreateSynchronousAsyncWorker().Object, serverProvider.Object, repo.Object, mockEventAggregator.Object, studioResourceRepository.Object);
            return envID;
        }

        protected static Mock<IEnvironmentRepository> CreateEnvironmentRepositoryMock()
        {
            var repo = new Mock<IEnvironmentRepository>();
            repo.Setup(l => l.Load()).Verifiable();

            var model = new Mock<IEnvironmentModel>();
            repo.Setup(l => l.Save(model.Object)).Verifiable();

            IList<IEnvironmentModel> models = new List<IEnvironmentModel>();
            repo.Setup(l => l.All()).Returns(models);


            return repo;
        }

        #endregion
    }
}
