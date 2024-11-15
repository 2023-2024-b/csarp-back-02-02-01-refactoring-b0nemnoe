using Kreata.Backend.Datas.Entities;
using Kreta.Shared.Models.Responses;

namespace Kreata.Backend.Repos
{
    public interface IClassRoomRepo
    {
        Task<List<ClassRoom>> GetAll();
        Task<ClassRoom?> GetBy(Guid id);
        Task<ControllerResponse> UpdateClassRoomAsync(ClassRoom entity);
    }
}
