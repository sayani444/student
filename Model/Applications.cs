using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAREERHUB_CodingChallenge.Model
{
    internal class Applications
    {
        private int applicationId;
        private int jobId;
        private int applicantId;
        private DateTime applicationDate;
        private string coverLetter;

        public Applications() { }

        public Applications(int applicationId, int jobId, int applicantId, DateTime applicationDate, string coverLetter)
        {
            this.applicationId = applicationId;
            this.jobId = jobId;
            this.applicantId = applicantId;
            this.applicationDate = applicationDate;
            this.coverLetter = coverLetter;
        }
        public int ApplicationId
        {
            get { return applicationId; }
            set { applicationId = value; }
        }
        public int JobId
        {
            get { return jobId; }
            set { jobId = value; }
        }

        public int ApplicantId
        {
            get { return applicantId; }
            set { applicantId = value; }
        }

        public DateTime ApplicationDate
        {
            get { return applicationDate; }
            set { applicationDate = value; }
        }

        public string CoverLetter
        {
            get { return coverLetter; }
            set { coverLetter = value; }
        }

    }
}
