﻿using FlaUI.Core;
using FlaUI.Core.AutomationElements;
using FlaUI.UIA3;
using System.Configuration;

namespace DMAutoTests
{
    public class ApplicationManager
    {
        private readonly NavigationHelper navigationHelper;
        private readonly OperatorPanelHelper operatorPanelHelper;
        private readonly FileWorker fileWorker;
        private readonly string appPath;

        public ApplicationManager() 
        {
            string appPath = ConfigurationManager.AppSettings["AppPath"];
            Application application = Application.Launch(appPath);
            UIA3Automation automation = new UIA3Automation();
            MainWindow = application.GetMainWindow(automation);
            navigationHelper = new NavigationHelper(this);
            operatorPanelHelper = new OperatorPanelHelper(this);
            fileWorker = new FileWorker(this);
            this.appPath = appPath;
        }

        public void Stop()
        {
            MainWindow.Close();
        }

        public Window MainWindow 
            { get; private set; }
        public NavigationHelper NavigationHelper
        { get { return navigationHelper; } } 
        public OperatorPanelHelper OperatorPanelHelper
        { get { return operatorPanelHelper; } }
        public FileWorker FileWorker 
        { get { return fileWorker; } }
        public string GetAppPath()
        { return appPath; }
    }
}
