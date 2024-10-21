using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;


class Dashboard{
    WebDriver driver = new ChromeDriver();

    // Locators:
    private IWebElement addCourseButton = driver.findElement(By.xpath('//span[text()=" Add course "]/parent::button'));

}
