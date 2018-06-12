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
    public class SystemCountryCodeRepository :BaseADO, IDataRepository<SystemCountryCodePoco>
    {
        public void Add(params SystemCountryCodePoco[] items)
        {
            throw new NotImplementedException();
        }

        public void CallStoredProc(string name, params Tuple<string, string>[] parameters)
        {
            throw new NotImplementedException();
        }

        public IList<SystemCountryCodePoco> GetAll(params System.Linq.Expressions.Expression<Func<SystemCountryCodePoco, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public IList<SystemCountryCodePoco> GetList(System.Linq.Expressions.Expression<Func<SystemCountryCodePoco, bool>> where, params System.Linq.Expressions.Expression<Func<SystemCountryCodePoco, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public SystemCountryCodePoco GetSingle(System.Linq.Expressions.Expression<Func<SystemCountryCodePoco, bool>> where, params System.Linq.Expressions.Expression<Func<SystemCountryCodePoco, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public void Remove(params SystemCountryCodePoco[] items)
        {
            using (SqlConnection connection = new SqlConnection(_connString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                foreach (SystemCountryCodePoco poco in items)
                {
                    cmd.CommandText = @"Delete from System_Country_Codes where Code = @Code";
                    cmd.Parameters.AddWithValue("@Code", poco.Code);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }

        public void Update(params SystemCountryCodePoco[] items)
        {
            throw new NotImplementedException();
        }
    }
}
