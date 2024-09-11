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
            AutomationElement operatorPanelBase = GetOperatorPanelBase();
            AutomationElement operatorPanel = operatorPanelBase.FindFirstChild(cf => cf.ByAutomationId(automationId));
            return operatorPanel;
        }
        /// <summary>
        /// Get operator panel base
        /// </summary>
        /// <returns>operator panel base</returns>
        public AutomationElement GetOperatorPanelBase()
        {
            AutomationElement uiPanel = manager.MainWindow.FindFirstChild(cf => cf.ByAutomationId("uiPanel"));
            AutomationElement operatorPanelBase = uiPanel.FindFirstChild(cf => cf.ByAutomationId("operatorPanel"));
            return operatorPanelBase;
        }

        /// <summary>
        /// Login operator
        /// </summary>
        /// <param name="fromKeyboard">true - login from physical keyboard, false - login from virtual keyboard</param>
        /// <param name="operatorToLogin">operator to login from StaffMobile</param>
        /// <param name="operatorPanel">panel of main or secondary operator</param>
        /// <param name="operatorType">operator type - main or second</param>
        public void LoginOperator(bool fromKeyboard, StaffMobile operatorToLogin, AutomationElement operatorPanel, string operatorType)
        {
            AutomationElement uiPanel = manager.MainWindow.FindFirstChild(cf => cf.ByAutomationId("uiPanel"));
            if (IsLoggedIn(operatorPanel, operatorType))
            {
                if (IsLoggedIn(operatorToLogin, operatorPanel, operatorType))
                {
                    return;
                }
                LogoutOperator(operatorPanel, operatorType);
            }
            manager.NavigationHelper.ClickButtonByAutomationId(operatorPanel, $"_login{char.ToUpper(operatorType[0]) + operatorType.Substring(1)}OperatorButton");
            AutomationElement loginDialog = uiPanel.FindFirstChild(cf => cf.ByAutomationId("loginDialog"));
            AutomationElement keyboard = loginDialog.FindFirstChild(cf => cf.ByAutomationId("Keyboard"));
            if (fromKeyboard)
            {
                Keyboard.Type(operatorToLogin.Number);
                Keyboard.Press(FlaUI.Core.WindowsAPI.VirtualKeyShort.ENTER);
            }
            else
            {
                foreach (char digit in operatorToLogin.Number.TrimStart('0'))
                {
                    manager.NavigationHelper.ClickButtonByName(keyboard, digit.ToString());
                }
                manager.NavigationHelper.ClickButtonByName(keyboard, "OK");
            }
        }
        /// <summary>
        /// Check if specific operator is logged in
        /// </summary>
        /// <param name="operatorToLogin">operator to login from StaffMobile</param>
        /// <param name="operatorPanel">panel of main or secondary operator</param>
        /// <param name="operatorType">operator type - main or second</param>
        /// <returns></returns>
        private bool IsLoggedIn(StaffMobile operatorToLogin, AutomationElement operatorPanel, string operatorType)
        {
            return manager.NavigationHelper.GetLabelTextByAutomationId(operatorPanel, $"_{operatorType}OperatorValueLabel") == $"{operatorToLogin.Name} {operatorToLogin.Surname}";
        }
        /// <summary>
        /// Check if operator is logged in
        /// </summary>
        /// <param name="operatorPanel">panel of main or secondary operator</param>
        /// <param name="operatorType">type of operator - main or second</param>
        /// <returns></returns>
        private bool IsLoggedIn(AutomationElement operatorPanel, string operatorType)
        {
            AutomationElement logoutButton = operatorPanel.FindFirstChild(cf => cf.ByAutomationId($"_logout{char.ToUpper(operatorType[0]) + operatorType.Substring(1)}OperatorButton"));
            return logoutButton != null;
        }
        /// <summary>
        /// Logout operator
        /// </summary>
        public void LogoutOperator(AutomationElement operatorPanel, string operatorType)
        {
            manager.NavigationHelper.ClickButtonByAutomationId(operatorPanel, $"_logout{char.ToUpper(operatorType[0]) + operatorType.Substring(1)}OperatorButton");
        }
    }
}
