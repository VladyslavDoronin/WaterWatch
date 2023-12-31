﻿using Microsoft.AspNetCore.Mvc;
using WaterWatch.Repositories;
using WaterWatch.Models;

namespace WaterWatch.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WaterConsumptionController : ControllerBase
    {
        private readonly IWaterConsumptionRepository _waterConsumptionRepository;
        public WaterConsumptionController(IWaterConsumptionRepository waterConsumptionRepository) 
        {
            _waterConsumptionRepository = waterConsumptionRepository;
        }

        [HttpGet("/waterconsumption/getall")]
        public async Task<ActionResult<IEnumerable<WaterConsumption>>> GetAll()
        {
            var wcData = await _waterConsumptionRepository.GetAll();
            return Ok(wcData);
        }

        [HttpGet("/waterconsumption/topten")]
        public async Task<ActionResult<IEnumerable<WaterConsumption>>> GetTopTenConsumers()
        {
            var wcData = await _waterConsumptionRepository.GetTopTenConsumpers();
            return Ok(wcData);
        }
    }
}
