using OpenQA.Selenium;

namespace OpencartTesting.Pages
{
    public class LoginPage : MainPageHeader
    {
        public LoginPage(WebDriver driver) : base(driver)
        {
            this.driver = driver;
        }
        public IWebElement LoginInput
        {
            get
            {
                return driver.FindElement(By.Id("input-email"));
            }
        }
        public IWebElement PasswordInput
        {
            get
            {
                return driver.FindElement(By.Id("input-password"));
            }
        }
        public IWebElement EnterButton
        {
            get
            {
                return driver.FindElement(By.XPath("//input[@value='Login']"));
            }
        }

        public void LoginInputClick() => LoginInput.Click();
        public void LoginInputClear() => LoginInput.Clear();

        public LoginPage LoginInputSendKeys(string login)
        {
            LoginInput.SendKeys(login);
            return this;
        }
        public void PasswordInputClick() => PasswordInput.Click();
        public void PasswordInputClear() => PasswordInput.Clear();

        public LoginPage PasswordInputSendKeys(string password)
        {
            PasswordInput.SendKeys(password);
            return this;
        }

        public void EnterButtonClick()
        {
            EnterButton.Click();
        }
    }
}

