using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAREERHUB_CodingChallenge.Model
{
    internal class Jobs
    {
        private int jobId;
        private int companyId;
        private string jobTitle;
        private string jobDescription;
        private string jobLocation;
        private decimal salary;
        private string jobType;
        private DateTime postedDate;

        public Jobs() { }

        public Jobs(int jobId, int companyId, string jobTitle, string jobDescription, string jobLocation, decimal salary, string jobType, DateTime postedDate)
        {
            this.jobId = jobId;
            this.companyId = companyId;
            this.jobTitle = jobTitle;
            this.jobDescription = jobDescription;
            this.jobLocation = jobLocation;
            this.salary = salary;
            this.jobType = jobType;
            this.postedDate = postedDate;
        }
        public int JobId
        {
            get { return jobId; }
            set { jobId = value; }
        }
        public int CompanyId
        {
            get { return companyId; }
            set { companyId = value; }
        }

        public string JobTitle
        {
            get { return jobTitle; }
            set { jobTitle = value; }
        }

        public string JobDescription
        {
            get { return jobDescription; }
            set { jobDescription = value; }
        }

        public string JobLocation
        {
            get { return jobLocation; }
            set { jobLocation = value; }
        }
        public decimal Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public string JobType
        {
            get { return jobType; }
            set { jobType = value; }
        }

        public DateTime PostedDate
        {
            get { return postedDate; }
            set { postedDate = value; }
        }
    }
}
