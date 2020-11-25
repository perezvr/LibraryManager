using LibraryManager.Application.DTO.DTO;
using LibraryManager.Domain.Models;
using System.Collections.Generic;

namespace LibraryManager.Infrastructure.CrossCutting.Adapter.Interfaces
{
    public interface IMapperBase<TModel, TDTO> where TModel : ModelBase where TDTO : ModelBaseDTO
    {
        TModel MapperToEntity(TDTO tDTO);

        IEnumerable<TDTO> MapperToListDTO(IEnumerable<TModel> tModel);

        TDTO MapperToDTO(TModel tModel);
    }
}
