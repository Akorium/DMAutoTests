using DMAutoTests;
using FlaUI.Core.AutomationElements;
using FlaUI.Core.Input;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

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
            List<StaffMobile> staffMobiles = StaffMobile.GetAllData();
            StaffMobile operatorToLogin = staffMobiles.First();
            AutomationElement operatorPanel = manager.MainWindow.FindFirstDescendant(cf => cf.ByAutomationId("operatorPanel"));
            AutomationElement[] operatorPanelDescendants = operatorPanel.FindAllDescendants();
            ClickButtonFromArrayByAutomationId(operatorPanelDescendants, "_loginMainOperatorButton");
            AutomationElement loginDialog = manager.MainWindow.FindFirstDescendant(cf => cf.ByAutomationId("loginDialog"));
            AutomationElement keyboard = loginDialog.FindFirstDescendant(cf => cf.ByAutomationId("Keyboard"));
            AutomationElement[] keyboardButtons = keyboard.FindAllDescendants();
            if (fromKeyboard)
            {
                Keyboard.Type(operatorToLogin.Number);
                Keyboard.Press(FlaUI.Core.WindowsAPI.VirtualKeyShort.ENTER);
            }
            else
            {
                foreach (char digit in operatorToLogin.Number.TrimStart('0'))
                {
                    ClickButtonFromArrayByName(keyboardButtons, digit.ToString());
                }
            }
            ClickButtonFromArrayByName(keyboardButtons, "OK");
            Label mainOperatorValueLabel = manager.MainWindow.FindFirstDescendant(cf => cf.ByAutomationId("_mainOperatorValueLabel")).AsLabel();
            Assert.That($"{operatorToLogin.Name} {operatorToLogin.Surname}", Is.EqualTo(mainOperatorValueLabel.Text));
        }

        private static void ClickButtonFromArrayByAutomationId(AutomationElement[] operatorPanelDescendants, string automationId)
        {
            Button primaryOperatorLoginButton = operatorPanelDescendants.FirstOrDefault(btn => btn.Properties.AutomationId == automationId).AsButton();
            primaryOperatorLoginButton.Click();
        }

        private static void ClickButtonFromArrayByName(AutomationElement[] elements, string name)
        {
            Button digitButton = elements.FirstOrDefault(btn => btn.Properties.Name.Value == name).AsButton();
            digitButton.Click();
        }

        [TearDown]
        public void Logout()
        {
            AutomationElement operatorPanel = manager.MainWindow.FindFirstDescendant(cf => cf.ByAutomationId("operatorPanel"));
            AutomationElement[] operatorPanelDescendants = operatorPanel.FindAllDescendants();
            ClickButtonFromArrayByAutomationId(operatorPanelDescendants, "_logoutMainOperatorButton");
        }
    }
}
