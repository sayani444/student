
using System;
using System.Collections.Generic;
using CAREERHUB_CodingChallenge.Utils;
using CAREERHUB_CodingChallenge.Repository;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAREERHUB_CodingChallenge.Service
{
    internal class HubService : CareerhubImpl
    {
        readonly Careerhub _careerhub;
        private object _careerHub;

        public HubService(Careerhub careerhub)
        {
            _careerhub = careerhub;
        }
        public void InsertJob()
        {
            try
            {
                string databaseConnectionString = DbConnUtils.GetConnectionString();
                Console.WriteLine("Enter JobId");
                int jobId = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter CompanyId");
                int companyId = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter JobTitle");
                string jobTitle = Console.ReadLine();
                Console.WriteLine("Enter JobDescription");
                string jobDescription = Console.ReadLine();
                Console.WriteLine("Enter JobLocation");
                string jobLocation = Console.ReadLine();
                Console.WriteLine("Enter Salary");
                decimal salary = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter JobType");
                string jobType = Console.ReadLine();
                Console.WriteLine("Enter PostedDate yyyy-mm-dd ");
                DateTime postedDate = DateTime.Now;

                _careerhub.InsertJob(jobId, companyId, jobTitle, jobDescription, jobLocation, salary, jobType, postedDate);



                Console.WriteLine("Inserted Suessfully");


            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occured:(ex.Message)");


            }
        }
        public void InsertCompany()
        {
            try
            {
                string databaseConnectionString = DbConnUtils.GetConnectionString();
                Console.WriteLine("Enter CompanyId");
                int companyId = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter CompanyName");
                string companyName = Console.ReadLine();
                Console.WriteLine("Enter Location");
                string location = Console.ReadLine();

                _careerhub.InsertCompany(companyId, companyName, location);


                Console.WriteLine("Company inserted successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }





        }
        public void InsertApplicant()
        {
            try
            {
                Console.WriteLine("Enter Applicant ID:");
                int applicantId = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter First Name:");
                string firstName = Console.ReadLine();

                Console.WriteLine("Enter Last Name:");
                string lastName = Console.ReadLine();

                Console.WriteLine("Enter Email:");
                string email = Console.ReadLine();

                Console.WriteLine("Enter Phone:");
                string phone = Console.ReadLine();

                Console.WriteLine("Enter Resume:");
                string resume = Console.ReadLine();

                _careerhub.InsertApplicant(applicantId, firstName, lastName, email, phone, resume); 

            }

            catch ()
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }


        }


    }
}
