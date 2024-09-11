using FlaUI.Core.AutomationElements;
using NUnit.Framework;

namespace DMAutoTests
{
    [TestFixture]
    public class OperatorPanelTests : TestBase
    {
        [Test]
        public void SoftwareVersionTest()
        {
            string softwareVersionFromExecutable = manager.FileWorker.GetMUWExecutableVersion();
            AutomationElement operatorPanelBase = manager.OperatorPanelHelper.GetOperatorPanelBase();
            string softwareVersionFromOperatorPanelBase = manager.NavigationHelper.GetLabelTextByAutomationId(operatorPanelBase, "_versionLabel");
            Assert.That(softwareVersionFromOperatorPanelBase, Is.EqualTo(softwareVersionFromExecutable));

        }
        [TestCase(true, "main")]
        [TestCase(false, "main")]
        [TestCase(true, "second")]
        [TestCase(false, "second")]
        [Test]
        public void LoginTest(bool fromKeyboard, string operatorType)
        {
            StaffMobile operatorToLogin = StaffMobile.GetFirstOrDefault();
            CurrentState oldCurrentState = CurrentState.GetFirstOrDefault();
            if (operatorType == "main")
            {
                oldCurrentState.PrimaryOperatorId = operatorToLogin.Id;
            }
            else
            {
                oldCurrentState.SecondaryOperatorId = operatorToLogin.Id;
            }
            AutomationElement operatorPanel = manager.OperatorPanelHelper.GetOperatorPanel($"_{operatorType}OperatorPanel");
            manager.OperatorPanelHelper.LoginOperator(fromKeyboard, operatorToLogin, operatorPanel, operatorType);
            string loggedInOperatorNameAndSurname = manager.NavigationHelper.GetLabelTextByAutomationId(operatorPanel, $"_{operatorType}OperatorValueLabel");
            CurrentState newCurrentState = CurrentState.GetFirstOrDefault();
            Assert.That($"{operatorToLogin.Name} {operatorToLogin.Surname}", Is.EqualTo(loggedInOperatorNameAndSurname));
            if (operatorType == "main")
            {
                Assert.That(newCurrentState.PrimaryOperatorId, Is.EqualTo(operatorToLogin.Id));
            }
            else
            {
                Assert.That(newCurrentState.SecondaryOperatorId, Is.EqualTo(operatorToLogin.Id));
            }
            manager.OperatorPanelHelper.LogoutOperator(operatorPanel, operatorType);
        }
    }
}