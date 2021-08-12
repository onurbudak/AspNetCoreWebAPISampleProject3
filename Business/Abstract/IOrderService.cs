using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IOrderService
    {
        IDataResult<Guid> Create(Order entity);
        IDataResult<bool> Update(Order entity);
        IDataResult<bool> Delete(Order entity);
        IDataResult<List<Order>> Get();
        //IDataResult<Order> Get(Guid id);
        IDataResult<List<Order>> Get(Guid id);
        IDataResult<bool> ChangeStatus(Guid id, string status);
    }
}
