using System;

namespace CAREERHUB_CodingChallenge.Model
{
    internal class Companies
    {
        private int companyId;
        private string companyName;
        private string location;

        public Companies() { }

        public Companies(int companyId, string companyName, string location)
        {
            this.companyId = companyId;
            this.companyName = companyName;
            this.location = location;
        }

        public int CompanyId
        {
            get { return companyId; }
            set { companyId = value; }
        }

        public string CompanyName
        {
            get { return companyName; }
            set { companyName = value; }
        }

        public string Location
        {
            get { return location; }
            set { location = value; }
        }
    }
}
