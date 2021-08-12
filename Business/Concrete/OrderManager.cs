using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class OrderManager : IOrderService
    {
        IOrderDal _orderDal;
        public OrderManager(IOrderDal orderDal)
        {
            _orderDal = orderDal;
        }

        public IDataResult<bool> ChangeStatus(Guid id, string status)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Guid> Create(Order entity)
        {
            throw new NotImplementedException();
        }

        public IDataResult<bool> Delete(Order entity)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Order>> Get()
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Order>> Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<bool> Update(Order entity)
        {
            throw new NotImplementedException();
        }
    }
}
