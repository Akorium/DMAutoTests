using FlaUI.Core.AutomationElements;

namespace DMAutoTests
{
    public class NavigationHelper : HelperBase
    {
        public NavigationHelper(ApplicationManager manager) : base(manager) { }
        /// <summary>
        /// Click button by automationId
        /// </summary>
        /// <param name="parent">parent element of button</param>
        /// <param name="automationId">automationId of button</param>
        public void ClickButtonByAutomationId(AutomationElement parent, string automationId)
        {
            Button button = parent.FindFirstChild(cf => cf.ByAutomationId(automationId)).AsButton();
            button.Click();
        }
        /// <summary>
        /// Click button by name
        /// </summary>
        /// <param name="parent">parent element of button</param>
        /// <param name="name">name of button</param>
        public void ClickButtonByName(AutomationElement parent, string name)
        {
            Button button = parent.FindFirstChild(cf => cf.ByName(name)).AsButton();
            button.Click();
        }
        /// <summary>
        /// Get label by automationId
        /// </summary>
        /// <param name="parent">parent element of label</param>
        /// <param name="automationId">automationId of label</param>
        /// <returns></returns>
        public Label GetLabelByAutomationId(AutomationElement parent, string automationId)
        {
            Label label = parent.FindFirstChild(cf => cf.ByAutomationId(automationId)).AsLabel();
            return label;
        }
    }
}
