﻿using HelpingHands.Dtos;
using HelpingHands.Services.Contracts;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HelpingHands.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("AllowSpecificOrigins")]
    public class OngController : ControllerBase
    {
        private readonly IOngService _ongService;

        public OngController(IOngService ongService) 
        {
            _ongService = ongService;
        }
        [HttpGet("onguri")]
        public async Task<ActionResult<IEnumerable<GetOngDto>>> GetOngs()
        {
            var response =  await _ongService.GetOngs();
            return StatusCode(response.StatusCode, new
            {
                Message = response.Message,
                Data = response.Data
            });
        }

        [HttpGet("ong")]
        public async Task<ActionResult<GetOngDto>> GetOngById(int id)
        {
            var response = await _ongService.GetOng(id);
            return StatusCode(response.StatusCode, new
            {
                Message = response.Message,
                Data = response.Data
            });
        }
        /*
        [HttpPut("ong")]
        public async Task<ActionResult<GetOngDto>> UpdateOng(StoreOngDto ong,int id)
        {
            var ongGet = await _ongService.UpdateOng(ong,id);
            return Ok(ongGet);
        }
        */
        
        

    }
}
