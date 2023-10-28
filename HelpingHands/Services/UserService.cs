using AutoMapper;
using HelpingHands.Dtos;
using HelpingHands.Repositories.Contracts;
using HelpingHands.Responses;
using HelpingHands.Services.Contracts.UserService;
using System.Security.Claims;

namespace HelpingHands.Services
{
    public class UserService : IUserService
    {
        // private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        private readonly IOngRepository _ongRepository;

        public UserService(IUserRepository userRepository,IMapper mapper, IOngRepository ongRepository)
        {
            // _httpContextAccessor = httpContextAccessor;
            _userRepository = userRepository;
            _mapper = mapper;
            _ongRepository = ongRepository;
        }
        /*
        public Task<GetUserDto> GetUserByClaim()
        {
            var result = string.Empty;
            if (_httpContextAccessor.HttpContext != null)
            {
                result = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.Email);
            }
            return result;
        }
        */

        public async Task<Response<GetUserDto>> GetUserById(int id) 
        {
            try
            {
                var user = await _userRepository.GetUserById(id);
                if(user == null) 
                {
                    return new Response<GetUserDto>(StatusCodes.Status400BadRequest, "Utilizatorul nu a fost gasit");
                }
                var userDto = _mapper.Map<GetUserDto>(user);
                
                userDto.Ong = _mapper.Map<GetOngDto>(await _ongRepository.GetOngById(id));
                return new Response<GetUserDto>(StatusCodes.Status200OK, "Operatia a reusit", userDto);
            }
            catch(Exception ex)
            {
                throw ex;
            } 
            
        }
    }
}
