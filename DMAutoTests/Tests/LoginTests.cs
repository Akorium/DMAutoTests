using FlaUI.Core.AutomationElements;
using NUnit.Framework;

namespace DMAutoTests
{
    [TestFixture]
    public class LoginTests : TestBase
    {
        [TestCase(true)]
        [TestCase(false)]
        [Test]
        public void LoginTest(bool fromKeyboard)
        {
            StaffMobile operatorToLogin = StaffMobile.GetFirstOrDefault();
            AutomationElement mainOperatorPanel = manager.OperatorPanelHelper.GetOperatorPanel("_mainOperatorPanel");
            manager.NavigationHelper.ClickButtonByAutomationId(mainOperatorPanel, "_loginMainOperatorButton");
            manager.OperatorPanelHelper.LoginOperator(fromKeyboard, operatorToLogin.Number);
            Label mainOperatorValueLabel = manager.NavigationHelper.GetLabelByAutomationId(mainOperatorPanel, "_mainOperatorValueLabel");
            Assert.That($"{operatorToLogin.Name} {operatorToLogin.Surname}", Is.EqualTo(mainOperatorValueLabel.Text));
        }

        [TearDown]
        public void Logout()
        {
            manager.OperatorPanelHelper.LogoutOperator();
        }
    }
}