using AutoMapper;
using Business.Abstract;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Logging;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Logging.Log4Net;
using Core.CrossCuttingConcerns.Logging.Log4Net.Loggers;
using Core.Utilities.IoC;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Model;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;
        private readonly IMapper _mapper;

        public CustomerManager(ICustomerDal customerDal, IMapper mapper)
        
        {
            _customerDal = customerDal;
            _mapper = mapper;
        }

        [ValidationAspect(typeof(CustomerValidator))]
        public IDataResult<Guid> Create(Customer entity)
        {
            _customerDal.Add(entity);

            return new SuccessDataResult<Guid>(entity.Id);
        }

        public IResult Delete(Customer entity)
        {
            _customerDal.Delete(entity);
            return new SuccessResult();
        }


        [LogAspect(typeof(FileLogger))]
        public IDataResult<List<CustomerDto>> GetAll()
        {
            var data = _customerDal.GetAll();
            List<CustomerDto> result = _mapper.Map<List<CustomerDto>>(data);
            return new SuccessDataResult<List<CustomerDto>>(result);
        }

        public IDataResult<Customer> Get(Guid id)
        {
            return new SuccessDataResult<Customer>(_customerDal.Get(c => c.Id == id));
        }

        public IResult Update(Customer entity)
        {
            _customerDal.Update(entity);
            return new SuccessResult();
        }

        public IResult Validate(Guid id)
        {
            var result = _customerDal.Get(c => c.Id == id);

            if(result != null)
                return new SuccessResult();

            return new ErrorResult();
        }
    }
}
