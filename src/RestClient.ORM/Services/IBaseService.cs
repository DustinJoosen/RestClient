namespace RestClient.ORM.Services
{
    public interface IBaseService<TDto>
    {
        Task<List<TDto>> GetAll();
        Task<TDto> GetById(Guid id);
        Task<TDto> Create(TDto dto);
        Task<TDto> Update(Guid id, TDto dto);
        //Task<TDto> Delete(Guid id);
        //Task<TDto> Delete(TDto model);
    }
}