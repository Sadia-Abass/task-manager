using AutoMapper;
using EasyManagerApp.API.Application.DTOs;
using EasyManagerApp.API.Application.ViewModels;
using EasyManagerApp.API.Domain.Models;

namespace EasyManagerApp.API.Application.Helpers
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            CreateMap<GroupDTO, Group>();
            CreateMap<Group, GroupDTO>();
            CreateMap<Group, GroupVM>();
        }
    }
}
