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

        [When(@"I fill all the mandatory fields in the form (.*) (.*) and (.*)")]
        public void WhenIFillAllTheMandatoryFieldsInTheFormAnd(string name, int age, int Phone, Table table)
        {
            var account = table.CreateInstance<EmployeeDetails>();

            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age : " + age.ToString());
            Console.WriteLine("Phone Number: " + Phone.ToString());
            Console.WriteLine("Email: " + account.Email);


            //ScenarioContext.Current["InfoforNextStep"] = "Step1 Passed";
            //Console.WriteLine(ScenarioContext.Current["InfoforNextStep"].ToString());

        }

    }
}
