import time
from selenium import webdriver
from selenium.webdriver.support.ui import WebDriverWait
from selenium.webdriver.support import expected_conditions as EC
from selenium.webdriver.common.by import By
from selenium.webdriver.common.keys import Keys
from selenium.webdriver.common.alert import Alert

driver=webdriver.Chrome()
wait=lambda ele:WebDriverWait(driver,10).until(ele)
driver.get("https://www.google.com/")

searchBox=wait(lambda drv:drv.find_element_by_name("q"))
searchBox.send_keys("Hello World")

time.sleep(5)
searchBox.submit()

time.sleep(5)
driver.quit()
