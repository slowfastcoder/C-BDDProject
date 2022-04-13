using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SpecFlowProject2Selenium.Steps

    
{
    [Binding]
    public class SampleTableSteps
    {
        [When(@"I fill all the mandatory fields in the form")]
        public void WhenIFillAllTheMandatoryFieldsInTheForm(Table table)
        {
            //Here is a way to use the tables and store date
            var details = table.CreateSet<EmployeeDetails>();

            foreach(EmployeeDetails emp in details)
            {
                Console.WriteLine("The details of Employee :" + emp.Name);
                Console.WriteLine("*********************");
                Console.WriteLine(emp.Age);
                Console.WriteLine(emp.Email);
                Console.WriteLine(emp.Name);
                Console.WriteLine(emp.Phone);

            }
        }
    }
}
