using EmployeeManager.Business.Entities;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManager.Business.Dto
{
    public class EmployeeDto : DtoBase
    {
        public override ValidationResult Validate()
        {
            throw new NotImplementedException();
        }

        protected override EntityBase ToEntity()
        {
            throw new NotImplementedException();
        }
    }
}
