using Application.IService;
using Application.model;
using Application.Service;
using Domain.Enums;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers.v1
{
    public class JobTypeController : BaseController
    {
        private readonly IJobTypeService _iJobTypeService;
        private readonly ILogger<JobTypeController> _logger;
        public JobTypeController(IJobTypeService jobTypeService, ILogger<JobTypeController> logger)
        {
            _iJobTypeService = jobTypeService;
            _logger = logger;
        }
        [HttpPost]
        public async Task<IActionResult> Insert(JobTypeDto dto)
        {
            try
            {
                var res = await _iJobTypeService.InsertAsync(dto);
                return Ok(res);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var res = await _iJobTypeService.GetAsync();
                return Ok(res);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(long id)
        {
            try
            {
                var res = await _iJobTypeService.GetByIdAsync(id);
                return Ok(res);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(long id, JobTypeDto dto)
        {
            try
            {
                var res = await _iJobTypeService.Update(id, dto);
                return Ok(res);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
        [HttpPut("UpdateState")]
        public async Task<IActionResult> UpdateState(long id, State state)
        {
            try
            {
                var res = await _iJobTypeService.UpdateState(id, state);
                return Ok(res);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var res = await _iJobTypeService.Delete(id);
                return Ok(res);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}
