using System;
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

           
            hubService.InsertApplicant();

         
            Console.ReadLine();
        }
    }
}
