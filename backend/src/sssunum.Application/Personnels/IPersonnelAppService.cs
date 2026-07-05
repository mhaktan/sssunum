using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using sssunum.Personnels.Dto;

namespace sssunum.Personnels
{
    public interface IPersonnelAppService : IAsyncCrudAppService<
        PersonnelDto,
        long,
        PagedPersonnelResultRequestDto,
        CreatePersonnelDto,
        PersonnelDto>
    {
    }
}
