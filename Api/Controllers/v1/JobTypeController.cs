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
        public JobTypeController(IJobTypeService jobTypeService)
        {
            _iJobTypeService = jobTypeService;
        }
        [HttpPost]
        public async Task<IActionResult> Insert(JobTypeDto dto)
        {
            var res = await _iJobTypeService.InsertAsync(dto);
            return Ok(res);
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var res = await _iJobTypeService.GetAsync();
            return Ok(res);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(long id)
        {
            var res = await _iJobTypeService.GetByIdAsync(id);
            return Ok(res);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(long id, JobTypeDto dto)
        {
            var res = await _iJobTypeService.Update(id, dto);
            return Ok(res);
        }
        [HttpPut("UpdateState")]
        public async Task<IActionResult> UpdateState(long id, State state)
        {
            var res = await _iJobTypeService.UpdateState(id, state);
            return Ok(res);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var res = await _iJobTypeService.Delete(id);
            return Ok(res);
        }
    }
}
