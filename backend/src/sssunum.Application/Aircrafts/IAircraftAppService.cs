using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using sssunum.Aircrafts.Dto;

namespace sssunum.Aircrafts
{
    public interface IAircraftAppService : IAsyncCrudAppService<
        AircraftDto,
        long,
        PagedAircraftResultRequestDto,
        CreateAircraftDto,
        AircraftDto>
    {
    }
}
