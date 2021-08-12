using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        IDataResult<Guid> Create(Customer entity);
        IResult Update(Customer entity);
        IResult Delete(Customer entity);
        IDataResult<List<CustomerDto>> GetAll();
        IDataResult<Customer> Get(Guid id);
        IResult Validate(Guid id);
    }
}
