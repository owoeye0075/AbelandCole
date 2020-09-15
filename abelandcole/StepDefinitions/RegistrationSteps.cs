using abelandcole.PageObject;
using System;
using TechTalk.SpecFlow;

namespace abelandcole.StepDefinitions
{
    [Binding]
    public class RegistrationSteps
    {
        RegisPageObject regisPageObject;

        public  RegistrationSteps()
        {
            regisPageObject = new RegisPageObject();
        }

        [Given(@"the user navigate to ""(.*)""")]
        public void GivenTheUserNavigateTo(string url)
        {
            regisPageObject.NavigateUrl(url);
        }

        [Given(@"the user click signup")]
        public void GivenTheUserClickSignup()
        {
            regisPageObject.clickSignUp();
        }

        [Given(@"the user accept the cookies")]
        public void GivenTheUserAcceptTheCookies()
        {
            regisPageObject.setCookies();
        }


        [Given(@"the user select the Title")]
        public void GivenTheUserSelectTheTitle()
        {
            regisPageObject.enterGender();
        }
        
        [Given(@"the user enter the firstname""(.*)""")]
        public void GivenTheUserEnterTheFirstname(string fname)
        {
            regisPageObject.enterFirstName(fname);
        }

        [Given(@"the user send the lastname ""(.*)""")]
        public void GivenTheUserSendTheLastname(string lname)
        {
            regisPageObject.enterLastName(lname);
        }


        [Given(@"the user enter email address ""(.*)""")]
        public void GivenTheUserEnterEmailAddress(string email)
        {
            regisPageObject.enterEmail(email);
        }
        
        [Given(@"the user enter a valid password ""(.*)""")]
        public void GivenTheUserEnterAValidPassword(string pass)
        {
            regisPageObject.enterPass(pass);
        }
        
        [Given(@"the user enter the postcode""(.*)""")]
        public void GivenTheUserEnterThePostcode(string pcode)
        {
            regisPageObject.enterPostCode(pcode);
        }
        
        [Given(@"the user click find address")]
        public void GivenTheUserClickFindAddress()
        {
            regisPageObject.clickFindAddress();
        }

        [Given(@"the user select address from the dropdown")]
        public void GivenTheUserSelectAddressFromTheDropdown()
        {
            regisPageObject.clickAddressDropDown();

            regisPageObject.selectAdress();
        }


        [Given(@"the user enter description of where to keep order""(.*)""")]
        public void GivenTheUserEnterDescriptionOfWhereToKeepOrder(string discptn)
        {
            regisPageObject.enterDescription(discptn);
        }
        
        [Given(@"the user enter contact number""(.*)""")]
        public void GivenTheUserEnterContactNumber(String contactNo)
        {
            regisPageObject.setContacNo(contactNo);
        }
        
        [Given(@"the user select where he heard about the company")]
        public void GivenTheUserSelectWhereHeHeardAboutTheCompany()
        {
            regisPageObject.WhereYouhearDropDown();
            
        }
        
        [Given(@"the user to tick he/she is a vegetarian")]
        public void GivenTheUserToTickHeSheIsAVegetarian()
        {
            regisPageObject.selectVegetarian();
        }
        
        [Given(@"the user to tick the box if he/she is a vegan")]
        public void GivenTheUserToTickTheBoxIfHeSheIsAVegan()
        {
            regisPageObject.selectveganBox();
        }
        
        [Given(@"the user to tick yes or No if he or she likes to recieve regulary email from company")]
        public void GivenTheUserToTickYesOrNoIfHeOrSheLikesToRecieveRegularyEmailFromCompany()
        {
            regisPageObject.selectHearUs();
        }
        
        [When(@"the user click signUp button")]
        public void WhenTheUserClickSignUpButton()
        {
            regisPageObject.clickCompleteSignUp();
        }

// [Then(@"the user should be succesffully registered")]
      //  public void ThenTheUserShouldBeSuccesffullyRegistered()
        //{
            //ScenarioContext.Current.Pending();
        //}
    }
}
