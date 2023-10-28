using AutoMapper;
using HelpingHands.Dtos;
using HelpingHands.Repositories;
using HelpingHands.Repositories.Contracts;
using HelpingHands.Responses;
using HelpingHands.Services.Contracts;

namespace HelpingHands.Services
{
    public class OngService : IOngService
    {
        private readonly IOngRepository _ongRepostiory;
        private readonly IMapper _mapper;

        public OngService(IOngRepository ongRepository,IMapper mapper) 
        {
            _ongRepostiory = ongRepository;
            _mapper = mapper;
        }

        public async Task<Response<GetOngDetailsDto>> GetOng(int id)
        {
            try
            {
                var ong = await _ongRepostiory.GetOngById(id);
                if (ong == null)
                {
                    return new Response<GetOngDetailsDto>(StatusCodes.Status400BadRequest, "Ong-ul nu a fost gasit");
                }

                
           
                return new Response<GetOngDetailsDto>(StatusCodes.Status200OK, "Operatia a reusit", _mapper.Map<GetOngDetailsDto>(ong));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Response<IEnumerable<GetOngDto>>> GetOngs()
        { 
            var ongs =  _mapper.Map<IEnumerable<GetOngDto>>(await _ongRepostiory.GetOngs());
            return new Response<IEnumerable<GetOngDto>>(StatusCodes.Status200OK, "Operatia a reusit", ongs);
        }
    }
}
