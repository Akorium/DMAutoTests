using DMAutoTests;
using FlaUI.Core.AutomationElements;
using FlaUI.Core.Input;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

[TestFixture]
public class WinFormsAppTests : TestBase
{
    [Test]
    public void TestButtonClick()
    {
        List<StaffMobile> staffMobiles = StaffMobile.GetAllData();
        StaffMobile operatorToLogin = staffMobiles.First();
        Button primaryOperatorLoginButton = manager.MainWindow.FindFirstDescendant(cf => cf.ByAutomationId("_loginMainOperatorButton")).AsButton();
        primaryOperatorLoginButton.Click();
        Keyboard.Type(operatorToLogin.Number);
        AutomationElement keyboard = manager.MainWindow.FindFirstDescendant(cf => cf.ByAutomationId("Keyboard"));
        AutomationElement[] keyboardButtons = keyboard.FindAllDescendants();
        Button submitButton = keyboardButtons.FirstOrDefault(btn => btn.Properties.Name.Value == "OK").AsButton();
        submitButton.Click();
        Label mainOperatorValueLabel = manager.MainWindow.FindFirstDescendant(cf => cf.ByAutomationId("_mainOperatorValueLabel")).AsLabel();
        Assert.That($"{operatorToLogin.Name} {operatorToLogin.Surname}", Is.EqualTo(mainOperatorValueLabel.Text));
    }
    [TearDown]
    public void Logout()
    {
        Button logoutButton = manager.MainWindow.FindFirstDescendant(cf => cf.ByAutomationId("_logoutMainOperatorButton")).AsButton();
        logoutButton.Click();
    }
}