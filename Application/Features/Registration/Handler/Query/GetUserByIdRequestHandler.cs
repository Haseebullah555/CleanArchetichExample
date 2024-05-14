//using Application.Contracts.Interfaces;
//using Application.DTOs.Registeration;
//using Application.Features.Registration.Request.Query;
//using AutoMapper;
//using MediatR;

//namespace Application.Features.Registration.Handler.Query
//{
//    public class GetUserByIdRequestHandler : IRequestHandler<GetUserByIdRequest, UserDto>
//    {
//        private readonly IUserRegisterationRepository _userRegisterationRepository;
//        private readonly IMapper _mapper;

//        public GetUserByIdRequestHandler(IUserRegisterationRepository userRegisterationRepository, IMapper mapper)
//        {
//            _userRegisterationRepository = userRegisterationRepository;
//            _mapper = mapper;
//        }
//        public async Task<UserDto> Handle(GetUserByIdRequest request, CancellationToken cancellationToken)
//        {
//            var user = await _userRegisterationRepository.GetById(request.Id);
//            return _mapper.Map<UserDto>(user);
//        }
//    }
//}
