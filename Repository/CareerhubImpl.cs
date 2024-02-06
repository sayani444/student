﻿using CAREERHUB_CodingChallenge.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAREERHUB_CodingChallenge.Repository
{
    internal interface CareerhubImpl
    {
        // void InsertJob();
        // void DisplayJobListings();
        public void InsertJob();
public void InsertCompany();
public void InsertApplicant();
public void InsertApplication();
public List<JobListing> GetJobListings();
public List<Company> GetCompanies();
public List<Applicant> GetApplicants();
public List<JobApplication> GetApplicationsForJob();
    }
}
