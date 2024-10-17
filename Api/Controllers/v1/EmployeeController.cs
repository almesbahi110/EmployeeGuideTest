using Application.IService;
using Application.model;
using Domain.Enums;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Diagnostics;

namespace Api.Controllers.v1
{

    public class EmployeeController : BaseController
    {
        private readonly IEmployeeService _iEmployeeService;
        private readonly ILogger<EmployeeController> _logger;
        public EmployeeController(IEmployeeService iEmployeeService, ILogger<EmployeeController> logger)
        {
            _iEmployeeService = iEmployeeService;
            _logger = logger;
        }
        [HttpPost]
        public async Task<IActionResult> Insert(EmployeeDto dto)
        {
            try
            {
                var res = await _iEmployeeService.InsertAsync(dto);
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
                var res = await _iEmployeeService.GetAsync();
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
                var res = await _iEmployeeService.GetByIdAsync(id);
                return Ok(res);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(long id, EmployeeDto dto)
        {
            try
            {
                var res = await _iEmployeeService.Update(id, dto);
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
                var res = await _iEmployeeService.UpdateState(id, state);
                return Ok(res);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(long id)
        {
            try
            {
                var res = await _iEmployeeService.Delete(id);
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
