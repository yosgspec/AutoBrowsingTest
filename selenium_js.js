const util=require("util");
const setTimeoutp=util.promisify(setTimeout);
const {Builder,By,Key,until}=require("selenium-webdriver");

(async function(){
	const driver=new Builder().forBrowser("chrome").build();

	const wait=ele=>driver.wait(ele,10)
	driver.get("http://www.google.com");

	var searchBox=await wait(drv=>drv.findElement(By.name("q")));
	searchBox.sendKeys("Hello World");

	await setTimeoutp(5000);
	searchBox.submit();

	await setTimeoutp(5000);
	driver.quit();
})();
