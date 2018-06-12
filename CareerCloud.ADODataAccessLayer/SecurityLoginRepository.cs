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
    public class SecurityLoginRepository : BaseADO,IDataRepository<SecurityLoginPoco>
    {
        public void Add(params SecurityLoginPoco[] items)
        {
            using (SqlConnection connection = new SqlConnection(_connString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                int rowsAffected = 0;

                foreach (SecurityLoginPoco poco in items)
                {
                    cmd.CommandText = @"INSERT INTO Company_Job_Skills (Id, Login, Password, Created_Date, 
                                        Password_Update_Date, Agreement_Accepted_Date,Is_Locked,Is_Inactive,
                                        Email_Address, Phone_Number,Full_Name, Force_Change_Password, 
                                        Prefferred_Language) values
										(@Id,@Login, @Password, @Created_Date, 
                                        @Password_Update_Date, @Agreement_Accepted_Date,@Is_Locked,@Is_Inactive,
                                        @Email_Address, @Phone_Number,@Full_Name, @Force_Change_Password, 
                                        @Prefferred_Language)";
                    cmd.Parameters.AddWithValue("@Id", poco.Id);
                    cmd.Parameters.AddWithValue("@Login", poco.Login);
                    cmd.Parameters.AddWithValue("@Password", poco.Password);
                    cmd.Parameters.AddWithValue("@Created_Date", poco.Created);
                    cmd.Parameters.AddWithValue("@Password_Update_Date", poco.PasswordUpdate);
                    cmd.Parameters.AddWithValue("@Agreement_Accepted_Date", poco.AgreementAccepted);
                    cmd.Parameters.AddWithValue("@Is_Locked", poco.IsLocked);
                    cmd.Parameters.AddWithValue("@Is_Inactive", poco.IsInactive);
                    cmd.Parameters.AddWithValue("@Email_Address", poco.EmailAddress);
                    cmd.Parameters.AddWithValue("@Phone_Number", poco.PhoneNumber);
                    cmd.Parameters.AddWithValue("@Full_Name", poco.FullName);
                    cmd.Parameters.AddWithValue("@Force_Change_Password", poco.ForceChangePassword);
                    cmd.Parameters.AddWithValue("@Prefferred_Language", poco.PrefferredLanguage);


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

        public IList<SecurityLoginPoco> GetAll(params System.Linq.Expressions.Expression<Func<SecurityLoginPoco, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public IList<SecurityLoginPoco> GetList(System.Linq.Expressions.Expression<Func<SecurityLoginPoco, bool>> where, params System.Linq.Expressions.Expression<Func<SecurityLoginPoco, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public SecurityLoginPoco GetSingle(System.Linq.Expressions.Expression<Func<SecurityLoginPoco, bool>> where, params System.Linq.Expressions.Expression<Func<SecurityLoginPoco, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public void Remove(params SecurityLoginPoco[] items)
        {
            using (SqlConnection connection = new SqlConnection(_connString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                foreach (SecurityLoginPoco poco in items)
                {
                    cmd.CommandText = @"Delete from Security_Logins where id = @id";
                    cmd.Parameters.AddWithValue("@id", poco.Id);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }

        public void Update(params SecurityLoginPoco[] items)
        {
            throw new NotImplementedException();
        }
    }
}
