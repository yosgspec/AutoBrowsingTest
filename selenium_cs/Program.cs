using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

class Program{
	static void Main(){
		var driver=new ChromeDriver();
		Func<Func<IWebDriver,IWebElement>,IWebElement> wait=
			ele=>new WebDriverWait(driver,TimeSpan.FromSeconds(10)).Until(ele);
		driver.Url="https://www.google.com/";

		var searchBox=wait(drv=>driver.FindElement(By.Name("q")));
		searchBox.SendKeys("Hello World");

		Thread.Sleep(5000);
		searchBox.Submit();

		Thread.Sleep(5000);
		driver.Quit();
	}
}
