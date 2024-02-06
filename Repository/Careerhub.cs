using CAREERHUB_CodingChallenge.Model;
using CAREERHUB_CodingChallenge.Utils;
using Microsoft.Data.SqlClient;
using System;

namespace CAREERHUB_CodingChallenge.Repository
{
    internal class Careerhub : CareerhubImpl
    {
        readonly string databaseConnectionString = DbConnUtils.GetConnectionString();
        private readonly object _careerHub;

        public Careerhub()
        {
            _careerHub = new object();
        }

        public void InsertJob(int jobId, int companyId, string jobTitle, string jobDescription, string jobLocation, decimal salary, string jobType, DateTime postedDate)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(databaseConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("INSERT INTO Jobs (JobId,CompanyId, JobTitle, JobDescription, JobLocation, Salary, JobType, PostedDate) VALUES (@JobId,@CompanyId, @JobTitle, @JobDescription, @JobLocation, @Salary, @JobType, @PostedDate)", connection))
                    {
                        command.Parameters.AddWithValue("@JobId", jobId);
                        command.Parameters.AddWithValue("@CompanyId", companyId);
                        command.Parameters.AddWithValue("@JobTitle", jobTitle);
                        command.Parameters.AddWithValue("@JobDescription", jobDescription);
                        command.Parameters.AddWithValue("@JobLocation", jobLocation);
                        command.Parameters.AddWithValue("@Salary", salary);
                        command.Parameters.AddWithValue("@JobType", jobType);
                        command.Parameters.AddWithValue("@PostedDate", postedDate);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while inserting the job: {ex.Message}");
            }
        }

        public void InsertCompany(int companyId, string companyName, string location)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(databaseConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("INSERT INTO Companies (CompanyId, CompanyName, Location) VALUES (@CompanyId, @CompanyName, @Location)", connection))
                    {
                        command.Parameters.AddWithValue("@CompanyId", companyId);
                        command.Parameters.AddWithValue("@CompanyName", companyName);
                        command.Parameters.AddWithValue("@Location", location);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            Console.WriteLine("Company inserted successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Error: Company not inserted.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while inserting the company: {ex.Message}");
            }
        }

        public void InsertApplicant(int applicantId, string firstName, string lastName, string email, string phone, string resume)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(databaseConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("INSERT INTO Applicants (ApplicantID, FirstName, LastName, Email, Phone, Resume) VALUES (@ApplicantID, @FirstName, @LastName, @Email, @Phone, @Resume)", connection))
                    {
                        command.Parameters.AddWithValue("@ApplicantID", applicantId);
                        command.Parameters.AddWithValue("@FirstName", firstName);
                        command.Parameters.AddWithValue("@LastName", lastName);
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@Phone", phone);
                        command.Parameters.AddWithValue("@Resume", resume);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            Console.WriteLine("Applicant inserted successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Error: Applicant not inserted.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while inserting the applicant: {ex.Message}");
            }
        }

        public void InsertApplication(int applicationId, int jobId, int applicantId, DateTime applicationDate, string coverLetter)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(databaseConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("INSERT INTO Applications (ApplicationID, JobID, ApplicantID, ApplicationDate, CoverLetter) VALUES (@ApplicationID, @JobID, @ApplicantID, @ApplicationDate, @CoverLetter)", connection))
                    {
                        command.Parameters.AddWithValue("@ApplicationID", applicationId);
                        command.Parameters.AddWithValue("@JobID", jobId);
                        command.Parameters.AddWithValue("@ApplicantID", applicantId);
                        command.Parameters.AddWithValue("@ApplicationDate", applicationDate);
                        command.Parameters.AddWithValue("@CoverLetter", coverLetter);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            Console.WriteLine("Job application inserted successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Error: Job application not inserted.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while inserting the job application: {ex.Message}");
            }
        }
        public List<JobListing> GetJobListings()
        {
            List<JobListing> jobListings = new List<JobListing>();

            try
            {
                using (SqlConnection connection = new SqlConnection(databaseConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SELECT * FROM Jobs", connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                JobListing jobListing = new JobListing
                                {
                                    JobID = Convert.ToInt32(reader["JobID"]),
                                    CompanyID = Convert.ToInt32(reader["CompanyID"]),
                                    JobTitle = reader["JobTitle"].ToString(),
                                    JobDescription = reader["JobDescription"].ToString(),
                                    JobLocation = reader["JobLocation"].ToString(),
                                    Salary = Convert.ToDecimal(reader["Salary"]),
                                    JobType = reader["JobType"].ToString(),
                                    PostedDate = Convert.ToDateTime(reader["PostedDate"])
                                };

                                jobListings.Add(jobListing);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while retrieving job listings: {ex.Message}");
            }

            return jobListings;
        }
        public List<Company> GetCompanies()
        {
            List<Company> companies = new List<Company>();

            try
            {
                using (SqlConnection connection = new SqlConnection(databaseConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SELECT * FROM Companies", connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Company company = new Company
                                {
                                    CompanyID = Convert.ToInt32(reader["CompanyID"]),
                                    CompanyName = reader["CompanyName"].ToString(),
                                    Location = reader["Location"].ToString()
                                };

                                companies.Add(company);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while retrieving companies: {ex.Message}");
            }

            return companies;
        }
        public List<Applicant> GetApplicants()
        {
            List<Applicant> applicants = new List<Applicant>();

            try
            {
                using (SqlConnection connection = new SqlConnection(databaseConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SELECT * FROM Applicants", connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Applicant applicant = new Applicant
                                {
                                    ApplicantID = Convert.ToInt32(reader["ApplicantID"]),
                                    FirstName = reader["FirstName"].ToString(),
                                    LastName = reader["LastName"].ToString(),
                                    Email = reader["Email"].ToString(),
                                    Phone = reader["Phone"].ToString(),
                                    Resume = reader["Resume"].ToString()
                                };

                                applicants.Add(applicant);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while retrieving applicants: {ex.Message}");
            }

            return applicants;
        }
        public List<JobApplication> GetApplicationsForJob(int jobID)
        {
            List<JobApplication> jobApplications = new List<JobApplication>();

            try
            {
                using (SqlConnection connection = new SqlConnection(databaseConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SELECT * FROM Applications WHERE JobID = @JobID", connection))
                    {
                        command.Parameters.AddWithValue("@JobID", jobID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                JobApplication jobApplication = new JobApplication
                                {
                                    ApplicationID = Convert.ToInt32(reader["ApplicationID"]),
                                    JobID = Convert.ToInt32(reader["JobID"]),
                                    ApplicantID = Convert.ToInt32(reader["ApplicantID"]),
                                    ApplicationDate = Convert.ToDateTime(reader["ApplicationDate"]),
                                    CoverLetter = reader["CoverLetter"].ToString()
                                };

                                jobApplications.Add(jobApplication);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while retrieving job applications: {ex.Message}");
            }

            return jobApplications;
        }


    }
}
