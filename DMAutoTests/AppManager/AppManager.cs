using FlaUI.Core;
using FlaUI.Core.AutomationElements;
using FlaUI.UIA3;

namespace DMAutoTests
{
    public class ApplicationManager
    {
        public ApplicationManager() 
        {
            Application application = Application.Launch(@"C:\Users\vanya\Downloads\5707-56090-muv\MobileUnitDrill\bin\Debug\MobileUnit.exe");
            UIA3Automation automation = new UIA3Automation();
            MainWindow = application.GetMainWindow(automation);
        }
        public void Stop()
        {
            MainWindow.Close();
        }
        public Window MainWindow 
            { get; private set; }
    }
}
