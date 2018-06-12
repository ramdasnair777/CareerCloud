using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CareerCloud.DataAccessLayer;
using CareerCloud.Pocos;

namespace CareerCloud.ADODataAccessLayer
{
    public class CompanyProfileRepository : BaseADO,IDataRepository<CompanyProfilePoco>
    {
        public void Add(params CompanyProfilePoco[] items)
        {
            using (SqlConnection connection = new SqlConnection(_connString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                int rowsAffected = 0;

                foreach (CompanyProfilePoco poco in items)
                {
                    cmd.CommandText = @"INSERT INTO Company_Job_Skills (Id, Registration_Date, Company_Website, Contact_Phone, 
                                        Contact_Name, Company_Logo) values
										(@Id, @Registration_Date, @Company_Website, @Contact_Phone, 
                                         @Contact_Name, @Company_Logo)";
                    cmd.Parameters.AddWithValue("@Id", poco.Id);
                    cmd.Parameters.AddWithValue("@Registration_Date", poco.RegistrationDate);
                    cmd.Parameters.AddWithValue("@Company_Website", poco.CompanyWebsite);
                    cmd.Parameters.AddWithValue("@Contact_Phone", poco.ContactPhone);
                    cmd.Parameters.AddWithValue("@Company_Logo", poco.CompanyLogo);
                    cmd.Parameters.AddWithValue("@Contact_Name", poco.ContactName);

                    connection.Open();
                    rowsAffected += cmd.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }

        public void CallStoredProc(string name, params Tuple<string, string>[] parameters)
        {
            throw new NotImplementedException();
        }

        public IList<CompanyProfilePoco> GetAll(params System.Linq.Expressions.Expression<Func<CompanyProfilePoco, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public IList<CompanyProfilePoco> GetList(System.Linq.Expressions.Expression<Func<CompanyProfilePoco, bool>> where, params System.Linq.Expressions.Expression<Func<CompanyProfilePoco, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public CompanyProfilePoco GetSingle(System.Linq.Expressions.Expression<Func<CompanyProfilePoco, bool>> where, params System.Linq.Expressions.Expression<Func<CompanyProfilePoco, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public void Remove(params CompanyProfilePoco[] items)
        {
            using (SqlConnection connection = new SqlConnection(_connString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                foreach (CompanyProfilePoco poco in items)
                {
                    cmd.CommandText = @"Delete from Company_Profiles where id = @id";
                    cmd.Parameters.AddWithValue("@id", poco.Id);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }

        public void Update(params CompanyProfilePoco[] items)
        {
            throw new NotImplementedException();
        }
    }
}
