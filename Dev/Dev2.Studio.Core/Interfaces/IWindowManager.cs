﻿using Dev2.Studio.Core.ViewModels.Base;
using System.Windows;

namespace Dev2.Studio.Core.Interfaces
{
    /// <summary>
    /// The purpose of this interface is to provide an abstraction for showing a window.
    /// All windows should be shown through the use of this interface as it allows code which
    /// would traditionaly be untestable to be testable.
    /// </summary>
    public interface IDev2WindowManager
    {
        void Show(MefLessBaseViewModel viewModel);
        void Show(Window window, MefLessBaseViewModel viewModel);
        void ShowDialog(Window window, MefLessBaseViewModel viewModel);
        void ShowDialog(MefLessBaseViewModel viewModel);
    }
}
