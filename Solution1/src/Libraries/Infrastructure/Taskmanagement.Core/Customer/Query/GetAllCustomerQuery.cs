﻿using AutoMapper;
using MediatR;
using Taskmanagement.Repositories.Interface;
using Taskmanagement.Services.Model;

namespace Taskmanagement.Core.Customer.Query;


public record GetAllCustomerQuery() : IRequest<IEnumerable<VmCustomer>>;
public class GetAllCustomerQueryHandler : IRequestHandler<GetAllCustomerQuery, IEnumerable<VmCustomer>>
{
    private readonly ICustomerRepository _customerRepository;

    public GetAllCustomerQueryHandler(ICustomerRepository customerRepository, IMapper mapper)
    {
        _customerRepository = customerRepository;
    }
    public async Task<IEnumerable<VmCustomer>> Handle(GetAllCustomerQuery request, CancellationToken cancellationToken)
    {
        var result = await _customerRepository.GetList();
        return result;
    }
}

