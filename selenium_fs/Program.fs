open System
open System.Threading
open OpenQA.Selenium
open OpenQA.Selenium.Chrome
open OpenQA.Selenium.Support.UI

let driver=new ChromeDriver()
let wait=new WebDriverWait (driver,TimeSpan.FromSeconds 10.0)

driver.Url<-"https://www.google.com/"

let searchBox=wait.Until(fun drv->(driver.FindElement) (By.Name "q"))
searchBox.SendKeys "Hello World"

Thread.Sleep 5000
searchBox.Submit()

Thread.Sleep 5000
driver.Quit()