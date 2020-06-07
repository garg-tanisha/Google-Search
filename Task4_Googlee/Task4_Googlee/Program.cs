using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Task4_Googlee
{
    class Program
    {
        static void Main(string[] args)
        {
            
                IWebDriver driver = new ChromeDriver();
                try
                {
                   // driver.Navigate().GoToUrl(@"https://selenium.dev");

                    //set url of driver 
                    driver.Url = "http://google.com";

                    //maximize browser as well
                    driver.Manage().Window.Maximize();

                    //set implicit time wait as well ( which stays for entire session) 
                    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

                    //finding element with the Name "q" and entering "Regression Testing" there, after that enter is pressed (keyboard)
                    driver.FindElement(By.Name("q")).SendKeys("Regression Testing" + Keys.Enter);

                    // press browser's back button
                    driver.Navigate().Back();

                    // press browser's front button
                    driver.Navigate().Forward();

                    // refresh current page
                    driver.Navigate().Refresh();

                    //current page title from the browser
                    Console.WriteLine(driver.Title);
            }
                catch (Exception e)
                {
                    Console.WriteLine("Exception encountered : " + e);
                }
                finally
                {
                    //close the browser
                    driver.Close();

                    //very important step
                    driver.Quit();
                }
            }
        }
    }

