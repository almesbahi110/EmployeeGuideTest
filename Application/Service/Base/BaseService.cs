using Application.IService.Base;
using Application.model.Base;
using AutoMapper;
using Domain.Entities.Base;
using Domain.Enums;
using Domain.IRepository.Base;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Application.Service.Base
{
    public abstract class BaseService<TEntity, TEntityDto> : IBaseService<TEntityDto> where TEntity : BaseEntity where TEntityDto : BaseDtoEntity
    {
        protected readonly IRepository<TEntity> _repository;
        protected readonly IMapper _mapper;

        public BaseService(IRepository<TEntity> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<TEntityDto> InsertAsync(TEntityDto dto)
        {
            await ValidationInsertRequest(dto);
            var entity = _mapper.Map<TEntity>(dto);
            var res = await _repository.InsertAsync(entity);
            return _mapper.Map<TEntityDto>(res);
        }
        public async Task<IEnumerable<TEntityDto>> GetAsync()
        {
            var res = await _repository.GetAsync();
            return _mapper.Map<IEnumerable<TEntityDto>>(res);
        }
        public async Task<TEntityDto> GetByIdAsync(long id)
        {
            var res = await _repository.GetByIdAsync(id);
            return _mapper.Map<TEntityDto>(res);
        }
        public async Task<TEntityDto> Update(long id, TEntityDto dto)
        {
            var existEntity = await _repository.GetByIdAsync(id);
          var entity=  _mapper.Map<TEntity>(dto);
            var res = _repository.Update(entity);
            return _mapper.Map<TEntityDto>(res);
        }
        public async Task<TEntityDto> Delete(long id)
        {
            var entity = await _repository.GetByIdAsync(id);
            var res = _repository.Delete(entity);
            return _mapper.Map<TEntityDto>(res);
        }
        protected abstract Task ValidationInsertRequest(TEntityDto dto);

        public async Task<TEntityDto> UpdateState(long id, State state)
        {
            var res = _repository.UpdateState(id, state);
            return _mapper.Map<TEntityDto>(res);
        }
    }
}