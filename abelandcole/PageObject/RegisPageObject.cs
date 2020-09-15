using abelandcole.StepDefinitions;
using abelandcole.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace abelandcole.PageObject
{
    class RegisPageObject
    {
        RegistrationSteps registrationSteps;
        public RegisPageObject()
        {
            driver = Hooks1.driver;
        }

        IWebDriver driver;

        IWebElement SignUP => driver.FindElement(By.XPath("//div[@class='sign-up menu-item']//a[contains(text(),'Sign up')]"));
        IWebElement acceptCookies => driver.FindElement(By.XPath("//*[@id='ccc-notify-accept']"));
        IWebElement secondDropDown => driver.FindElement(By.XPath("//div[@class='title-field']//span[@class='Dropdown-arrow']"));
        IWebElement marital55 => driver.FindElement(By.XPath("//div[contains(text(),'Miss')]"));
        IWebElement firstName => driver.FindElement(By.XPath("//input[@placeholder='First name*']"));

        IWebElement lastName => driver.FindElement(By.XPath("//input[@placeholder='Last name*']"));
        IWebElement eMail => driver.FindElement(By.XPath("//input[@placeholder='Email address*']"));
        IWebElement passWord => driver.FindElement(By.XPath("//input[@placeholder='Password*']"));
        IWebElement postCode => driver.FindElement(By.XPath("//input[@placeholder='Postcode*']"));
        IWebElement findAddress => driver.FindElement(By.XPath("//input[@name='findAddress']"));
        IWebElement dropDown => driver.FindElement(By.XPath("//div[@class='addresses-dropdown']//span[@class='Dropdown-arrow']"));
        IWebElement selectAddress => driver.FindElement(By.XPath("//div[contains(text(),'111 Stoneleigh Road, Birmingham')]"));
        IWebElement DescriptionBox=> driver.FindElement(By.Name("DeliveryNotes"));
        IWebElement telephoneNo => driver.FindElement(By.XPath("//input[contains(@placeholder,'Telephone or mobile number*')]"));
        IWebElement WheredropDown => driver.FindElement(By.XPath("//div[@class='how-did-you-hear-field']//span[@class='Dropdown-arrow']"));
        IWebElement wheredropdown2 => driver.FindElement(By.XPath("//div[contains(text(),'Radio')]"));
        IWebElement vegetarianBox => driver.FindElement(By.XPath("//label[contains(@class,'check-vegetarian clearfix')]//i"));
        IWebElement veganBox => driver.FindElement(By.XPath("//label[contains(@class,'check-vegan clearfix')]//i"));
        IWebElement hearFromUSBox => driver.FindElement(By.XPath("//div[contains(@class,'hearFromUs-container')]//label[2]//i[1]"));
        
        IWebElement completeSigUP => driver.FindElement(By.Id("cta-button"));
        IWebElement verifyAcc => driver.FindElement(By.Id("BasketTotal"));

        


        public void NavigateUrl(String url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public void clickSignUp()
        {
            SignUP.Click();
            Thread.Sleep(4000);
        }

        public void setCookies()
        {
            acceptCookies.Click();
        }
        public void enterGender()
        {
            secondDropDown.Click();
            Thread.Sleep(2000);
            marital55.Click();
            
        }

        public void enterFirstName(String fname)
        {
            firstName.SendKeys(fname);
        }

        public void enterLastName(String lname)
        {
            lastName.SendKeys(lname);
        }
        public void enterEmail(String email)
        {
            eMail.SendKeys(email);
        }
        public void enterPass(String pass)
        {
            passWord.SendKeys(pass);
        }

        public void enterPostCode(String pcode)
        {
            postCode.SendKeys(pcode);
        }

        public void clickFindAddress()
        {
            findAddress.Click();
            Thread.Sleep(3000);
        }

        public void clickAddressDropDown()
        {
            dropDown.Click();
            Thread.Sleep(3000);
        }
        public void selectAdress()
        {
            selectAddress.Click();
        }
        public void enterDescription(String discptn)
        {
            DescriptionBox.SendKeys(discptn);
        }
        public void setContacNo(String contactNo)
        {
            telephoneNo.SendKeys(contactNo);
        }
            public void WhereYouhearDropDown()
        {
            WheredropDown.Click();
            Thread.Sleep(2000);
            wheredropdown2.Click();


        }
        public void selectVegetarian()
        {
            vegetarianBox.Click();
        }
        public void selectveganBox()
        {
            veganBox.Click();
        }
        public void selectHearUs()
        {
            hearFromUSBox.Click();
        }
        public void clickCompleteSignUp()
        {
            completeSigUP.Click();
        }



        
        //public bool VerificationAcct()
       // {
           // Assert.That(verifyAcc.Displayed);
        //}
    }
}
