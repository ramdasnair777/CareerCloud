﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CareerCloud.DataAccessLayer;
using CareerCloud.Pocos;

namespace CareerCloud.BusinessLogicLayer
{
    public class CompanyProfileLogic:BaseLogic<CompanyProfilePoco>
    {
        public CompanyProfileLogic(IDataRepository<CompanyProfilePoco> repository) : base(repository)
        {
              
        }
        protected override void Verify(CompanyProfilePoco[] pocos)
        {
            List<ValidationException> exceptions = new List<ValidationException>();
            foreach (CompanyProfilePoco poco in pocos)
            {
                if (string.IsNullOrEmpty(poco.CompanyWebsite))
                {
                    exceptions.Add(new ValidationException(600, $"Cannot be empty or less than 3" +
                      $"characters -{poco.Id}"));
                }
                else if (!poco.CompanyWebsite.EndsWith(".ca") || !poco.CompanyWebsite.EndsWith(".com") ||
                    !poco.CompanyWebsite.EndsWith(".biz"))
                {
                    exceptions.Add(new ValidationException(600, $"Invalid web suffix " +
                        $"or empty -{poco.Id}"));
                }


                if (string.IsNullOrEmpty(poco.ContactPhone))
                {
                    exceptions.Add(new ValidationException(601, $"PhoneNumber for SecurityLogin {poco.Id} is required"));
                }
                else
                {
                    string[] phoneComponents = poco.ContactPhone.Split('-');
                    if (phoneComponents.Length < 3)
                    {
                        exceptions.Add(new ValidationException(601, $"PhoneNumber for SecurityLogin {poco.Id} is not in the required format."));
                    }
                    else
                    {
                        if (phoneComponents[0].Length < 3)
                        {
                            exceptions.Add(new ValidationException(601, $"PhoneNumber for SecurityLogin {poco.Id} is not in the required format."));
                        }
                        else if (phoneComponents[1].Length < 3)
                        {
                            exceptions.Add(new ValidationException(601, $"PhoneNumber for SecurityLogin {poco.Id} is not in the required format."));
                        }
                        else if (phoneComponents[2].Length < 4)
                        {
                            exceptions.Add(new ValidationException(601, $"PhoneNumber for SecurityLogin {poco.Id} is not in the required format."));
                        }
                    }
                }
            }
            

            if (exceptions.Count > 0)
            {
                throw new AggregateException(exceptions);
            }
        }

        public override void Add(CompanyProfilePoco[] pocos)
        {
            Verify(pocos);
            base.Add(pocos);
        }
        public override void Update(CompanyProfilePoco[] pocos)
        {
            Verify(pocos);
            base.Add(pocos);
        }
    }
}
