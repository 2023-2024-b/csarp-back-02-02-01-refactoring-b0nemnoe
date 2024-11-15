using Kreata.Backend.Context;
using Kreata.Backend.Datas.Entities;
using Kreta.Shared.Models.Responses;
using Microsoft.EntityFrameworkCore;

namespace Kreata.Backend.Repos
{
    public class ClassRoomRepo : IClassRoomRepo
    {
        private readonly KretaInMemoryContext _dbContext;

        public ClassRoomRepo(KretaInMemoryContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<ClassRoom?> GetBy(Guid id)
        {
            return await _dbContext.ClassRooms.FirstOrDefaultAsync(s => s.Id == id);
        }

        public async Task<List<ClassRoom>> GetAll()
        {
            return await _dbContext.ClassRooms.ToListAsync();
        }

        public async Task<ControllerResponse> UpdateClassRoomAsync(ClassRoom entity)
        {
            ControllerResponse response = new ControllerResponse();
            _dbContext.ChangeTracker.Clear();
            _dbContext.Entry(entity).State = EntityState.Modified;
            try
            {
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception e)
            {
                response.AppendNewError(e.Message);
                response.AppendNewError($"{nameof(ClassRoomRepo)} osztály, {nameof(UpdateClassRoomAsync)} metódusban hiba keletkezett");
                response.AppendNewError($"{entity} frissítése nem sikerült!");
            }
            return response;
        }
    }
}
