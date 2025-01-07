using NLayer.Core.Dtos;
using NLayer.Core.Entities;
using System.Linq.Expressions;

namespace NLayer.Core.Services
{
    public interface IServiceWithDto<Entitiy, Dto> where Entitiy: BaseEntity where Dto : class
    {
        Task<CustomResponseDto<Dto>> GetByIdAsync(int id);
        Task<CustomResponseDto<IEnumerable<Dto>>> GetAllAsync();
        Task<CustomResponseDto<IEnumerable<Dto>>> Where(Expression<Func<Entitiy, bool>> expression);
        Task<CustomResponseDto<bool>> AnyAsync(Expression<Func<Entitiy, bool>> expression);
        Task<CustomResponseDto<Dto>> AddAsync(Dto dto);
        Task<CustomResponseDto<IEnumerable<Dto>>> AddRangeAsync(IEnumerable<Dto> dto);
        Task<CustomResponseDto<NoContentDto>> UpdateAsync(Dto dto);
        Task<CustomResponseDto<NoContentDto>> RemoveAsync(int id);
        Task<CustomResponseDto<NoContentDto>> RemoveRangeAsync(IEnumerable<int> id);
    }
}
