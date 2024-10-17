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
        public EmployeeController(IEmployeeService iEmployeeService)
        {
            _iEmployeeService= iEmployeeService;
        }
        [HttpPost]
        public async Task<IActionResult> Insert(EmployeeDto dto)
        {
            var res = await _iEmployeeService.InsertAsync(dto);
            return Ok(res);
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var res = await _iEmployeeService.GetAsync();
            return Ok(res);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(long id)
        {
            var res = await _iEmployeeService.GetByIdAsync(id);
             return Ok(res);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(long id,EmployeeDto dto)
        {
            var res = await _iEmployeeService.Update(id,dto);
            return Ok(res);
        } 
        [HttpPut("UpdateState")]
        public async Task<IActionResult> UpdateState(long id, State state)
        {
            var res = await _iEmployeeService.UpdateState(id, state);
            return Ok(res);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(long id)
        {
            var res = await _iEmployeeService.Delete(id);
            return Ok(res);
        }
    }
}
