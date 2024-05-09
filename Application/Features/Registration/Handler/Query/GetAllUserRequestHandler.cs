using Application.Contracts.Interfaces;
using Application.DTOs.Registeration;
using Application.Features.Registration.Request.Query;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Registration.Handler.Query
{
    public class GetAllUserRequestHandler : IRequestHandler<GetAllUserRequest, List<UserRegisterDto>>
    {
        private readonly IUnitOfWork _UoW;
        private readonly IMapper _mapper;

        public GetAllUserRequestHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _UoW = unitOfWork;
            _mapper = mapper;
        }
        public Task<List<UserRegisterDto>> Handle(GetAllUserRequest request, CancellationToken cancellationToken)
        {
            var users
        }
    }
}
