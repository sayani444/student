using System;
using CAREERHUB_CodingChallenge.Model;
using CAREERHUB_CodingChallenge.Repository;
using CAREERHUB_CodingChallenge.Service;

namespace CAREERHUB_CodingChallenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Careerhub careerhub = new Careerhub();

          
            HubService hubService = new HubService(careerhub);

            

         
            hubService.InsertJob();

        
            hubService.InsertCompany();
            hubService.InsertApplication();

           
            hubService.InsertApplicant();
            hubService.List<Company> GetCompanies; 
            hubService.List<Applicant> GetApplicants(); 
            hubService.List<JobApplication> GetApplicationsForJob(); 

         
            Console.ReadLine();
        }
    }
}
