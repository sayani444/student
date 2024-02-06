using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAREERHUB_CodingChallenge.Model
{
    internal class Applicants
    {
        private int applicantId;
        private string firstName;
        private string lastName;
        private string email;
        private string phone;
        private string resume;

        public Applicants() { }

        public Applicants(int applicantId, string firstName, string lastName, string email, string phone, string resume)
        {
            this.applicantId = applicantId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.phone = phone;
            this.resume = resume;
        }
        public int ApplicantId
        {
            get { return applicantId; }
            set { applicantId = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        public string Resume
        {
            get { return resume; }
            set { resume = value; }
        }
    }
}
