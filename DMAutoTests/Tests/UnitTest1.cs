using DMAutoTests;
using FlaUI.Core.AutomationElements;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

[TestFixture]
public class WinFormsAppTests : TestBase
{
    [Test]
    public void TestButtonClick()
    {
        Button primaryOperatorLoginButton = manager.MainWindow.FindFirstDescendant(cf => cf.ByAutomationId("_loginMainOperatorButton")).AsButton();
        primaryOperatorLoginButton.Click();
        AutomationElement keyboard = manager.MainWindow.FindFirstDescendant(cf => cf.ByAutomationId("Keyboard"));
        AutomationElement[] keyboardButtons = keyboard.FindAllDescendants();
        Button cancelButton = keyboardButtons.FirstOrDefault(btn => btn.Properties.Name.Value == "Отмена").AsButton();
        cancelButton.Click();
    }
}