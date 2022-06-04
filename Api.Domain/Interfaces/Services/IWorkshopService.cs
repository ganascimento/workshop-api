using System.Threading.Tasks;
using Api.Domain.Dtos.Workshop;

namespace Api.Domain.Interfaces.Services
{
    public interface IWorkshopService
    {
        Task<WorkshopDto> Get();
        Task<bool> Create(WorkshopDtoCreate dto);
        Task<WorkshopDtoUpdateResult> Update(WorkshopDtoUpdate dto);
        Task<bool> Remove();
    }
}