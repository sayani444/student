using System;
using System.Collections.Generic;
using CAREERHUB_CodingChallenge.Utils;
using CAREERHUB_CodingChallenge.Repository;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAREERHUB_CodingChallenge.Model;

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

                Console.WriteLine("Inserted Successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
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
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
        public void DisplayJobListings(List<JobListing> jobListings)
        {
            Console.WriteLine("Job Listings:");
            foreach (var job in jobListings)
            {
                Console.WriteLine($"JobID: {job.JobID}");
                Console.WriteLine($"CompanyID: {job.CompanyID}");
                Console.WriteLine($"Title: {job.JobTitle}");
                Console.WriteLine($"Description: {job.JobDescription}");
                Console.WriteLine($"Location: {job.JobLocation}");
                Console.WriteLine($"Salary: {job.Salary}");
                Console.WriteLine($"Type: {job.JobType}");
                Console.WriteLine($"Posted Date: {job.PostedDate}");
                Console.WriteLine();
            }
        }
        public void GetCompanies()
        {
            try
            {
                Console.WriteLine("Retrieving companies...");

                List<Company> companies = _careerhub.GetCompanies();

                if (companies.Count > 0)
                {
                    Console.WriteLine("List of companies:");
                    foreach (var company in companies)
                    {
                        Console.WriteLine($"Company ID: {company.CompanyID}, Name: {company.CompanyName}, Location: {company.Location}");
                    }
                }
                else
                {
                    Console.WriteLine("No companies found.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
        public void GetApplicants()
        {
            try
            {
                List<Applicant> applicants = _careerhub.GetApplicants();

                if (applicants.Count > 0)
                {
                    Console.WriteLine("List of Applicants:");
                    foreach (var applicant in applicants)
                    {
                        Console.WriteLine($"Applicant ID: {applicant.ApplicantID}");
                        Console.WriteLine($"Name: {applicant.FirstName} {applicant.LastName}");
                        Console.WriteLine($"Email: {applicant.Email}");
                        Console.WriteLine($"Phone: {applicant.Phone}");
                        Console.WriteLine($"Resume: {applicant.Resume}");
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("No applicants found.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
        public List<JobApplication> GetApplicationsForJob(int jobID)
        {
            List<JobApplication> jobApplications = new List<JobApplication>();

            try
            {
                jobApplications = _careerhub.GetApplicationsForJob(jobID);

                if (jobApplications.Count > 0)
                {
                    Console.WriteLine($"Job applications for Job ID {jobID}:");
                    foreach (var application in jobApplications)
                    {
                        Console.WriteLine($"Application ID: {application.ApplicationID}");
                        Console.WriteLine($"Applicant ID: {application.ApplicantID}");
                        Console.WriteLine($"Application Date: {application.ApplicationDate}");
                        Console.WriteLine($"Cover Letter: {application.CoverLetter}");
                        Console.WriteLine("-");
                    }
                }
                else
                {
                    Console.WriteLine("No job applications found for the specified Job ID.");
