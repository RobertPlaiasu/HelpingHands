﻿using AutoMapper;
using HelpingHands.Dtos;
using HelpingHands.Entities;
using HelpingHands.Repositories;
using HelpingHands.Repositories.Contracts;
using HelpingHands.Services.Contracts;

namespace HelpingHands.Services
{
    public class NeedService : INeedService
    {
        private readonly INeedRepository _needRepository;
        private readonly IMapper _mapper;

        public NeedService(INeedRepository needRepository,IMapper mapper)
        {
            _needRepository = needRepository;
            _mapper = mapper;
        }

        public async Task<string> CreateNeed(PostNeedDto need)
        {
            return await _needRepository.CreateNeed(_mapper.Map<Need>(need));
        }

        public Task<IEnumerable<Need>> GetNeeds()
        {
            return _needRepository.GetNeeds();
        }

        public async Task<string> UpdateNeed(PostNeedDto need, int id)
        {
            var needEntity = _mapper.Map<Need>(need);
            needEntity.Id = id;
            return await _needRepository.UpdateNeed(needEntity);
        }
    }
}
