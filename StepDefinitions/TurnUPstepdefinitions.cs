using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SpecFlowProject1.Pages;
using SpecFlowProject1.Utilities;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class TurnUPstepdefinitions :CommonDriver
    {
        LoginPage loginPageobj=new LoginPage();
        HomePage homePageobj=new HomePage();
        TimeandMaterialPage timeandMaterialPageobj=new TimeandMaterialPage();

        [Given(@"User logs into TurnUpPortal")]
        public void GivenUserLogsIntoTurnUpPortal()
        {
            webDriver = new ChromeDriver();
            loginPageobj.LoginActions(webDriver,"hari","123123");
        }

        [Given(@"User navigate to Time and Materials Page")]
        public void GivenUserNavigateToTimeAndMaterialsPage()
        {
            homePageobj.NavigateToHomePage(webDriver);
        }

        [When(@"User clicks on <<CreateNew>> button")]
        public void WhenUserClicksOnCreateNewButton()
        {
            timeandMaterialPageobj.CreateNewTimeRecord(webDriver,"FIRSTIC");
        }

        [Then(@"New TM record is created")]
        public void ThenNewTMRecordIsCreated()
        {
            timeandMaterialPageobj.VerifyNewlyCreatedTimeRecord(webDriver);
        }

        [When(@"Edit an existing Time and Material record")]
        public void WhenEditAnExistingTimeAndMaterialRecord()
        {
            timeandMaterialPageobj.EditNewTimeRecord(webDriver);
        }

        [Then(@"Verify TMrecord is edited")]
        public void ThenVerifyTMrecordIsEdited()
        {
            timeandMaterialPageobj.VerifyEditedTimeRecord(webDriver);
        }

        [Given(@"User logs into TurnupPortal")]
        public void GivenUserLogsIntoIntoTurnupPortal()
        {
            loginPageobj.LoginActions(webDriver,"hari","123123");
        }

        [When(@"User navigate to Time and Materials page")]
        public void WhenUserNavigateToTimeAndMaterialsPage()
        {
            homePageobj.NavigateToHomePage(webDriver);
        }

        [When(@"User deletes an existing Time and Material record")]
        public void WhenUserDeletesAnExistingTimeAndMaterialRecord()
        {
            timeandMaterialPageobj.DeleteTimeRecord(webDriver);
        }

        [Then(@"Verify TM record is deleted")]
        public void ThenVerifyTMRecordIsDeleted()
        {
            timeandMaterialPageobj.VerifyDeleteTimeRecord(webDriver);
        }
    }
}
