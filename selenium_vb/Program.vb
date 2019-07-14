Option Strict On
Option Infer On
Imports System.Threading
Imports OpenQA.Selenium
Imports OpenQA.Selenium.Chrome
Imports OpenQA.Selenium.Support.UI

Module Program
	Sub Main()
		Dim driver As New ChromeDriver()
		Dim wait As Func(Of Func(Of IWebDriver,IWebElement),IWebElement)=
			Function(ele) New WebDriverWait(driver,TimeSpan.FromSeconds(10)).Until(ele)
		driver.Url="https://www.google.com/"

		Dim searchBox=wait(Function(drv) driver.FindElement(By.Name("q")))
		searchBox.SendKeys("Hello World")

		Thread.Sleep(5000)
		searchBox.Submit()

		Thread.Sleep(5000)
		driver.Quit()
	End Sub
End Module
