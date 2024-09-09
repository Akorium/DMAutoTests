using FlaUI.Core.AutomationElements;
using FlaUI.Core.Input;

namespace DMAutoTests
{
    public class OperatorPanelHelper : HelperBase
    {
        public OperatorPanelHelper(ApplicationManager manager) : base(manager) { }
        /// <summary>
        /// Get main or secondary operator panel, depends on automationId
        /// </summary>
        /// <param name="automationId">"_mainOperatorPanel" or "_secondaryOperatorPanel"</param>
        /// <returns>main or secondary operator panel</returns>
        public AutomationElement GetOperatorPanel(string automationId)
        {
            AutomationElement uiPanel = manager.MainWindow.FindFirstChild(cf => cf.ByAutomationId("uiPanel"));
            AutomationElement operatorPanelBase = uiPanel.FindFirstChild(cf => cf.ByAutomationId("operatorPanel"));
            AutomationElement operatorPanel = operatorPanelBase.FindFirstChild(cf => cf.ByAutomationId(automationId));
            return operatorPanel;
        }
        /// <summary>
        /// Login operator
        /// </summary>
        /// <param name="fromKeyboard">true - login from physical keyboard, false - login from virtual keyboard</param>
        /// <param name="number">operator number</param>
        public void LoginOperator(bool fromKeyboard, string number)
        {
            AutomationElement uiPanel = manager.MainWindow.FindFirstChild(cf => cf.ByAutomationId("uiPanel"));
            AutomationElement loginDialog = uiPanel.FindFirstChild(cf => cf.ByAutomationId("loginDialog"));
            AutomationElement keyboard = loginDialog.FindFirstChild(cf => cf.ByAutomationId("Keyboard"));
            if (fromKeyboard)
            {
                Keyboard.Type(number);
                Keyboard.Press(FlaUI.Core.WindowsAPI.VirtualKeyShort.ENTER);
            }
            else
            {
                foreach (char digit in number.TrimStart('0'))
                {
                    manager.NavigationHelper.ClickButtonByName(keyboard, digit.ToString());
                }
            }
            manager.NavigationHelper.ClickButtonByName(keyboard, "OK");
        }
        /// <summary>
        /// Logout operator
        /// </summary>
        public void LogoutOperator()
        {
            AutomationElement operatorPanel = manager.OperatorPanelHelper.GetOperatorPanel("_mainOperatorPanel");
            manager.NavigationHelper.ClickButtonByAutomationId(operatorPanel, "_logoutMainOperatorButton");
        }
        
    }
}
