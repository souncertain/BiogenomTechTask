using AutoMapper;
using BiogenomTechTask.Domain.Entities;
using BiogenomTechTask.Domain.Models;

namespace BiogenomTechTask.BL.Mapping
{
    public class MappingConfig : Profile
    {
        public MappingConfig() 
        {
            CreateMap<Product, ProductModel>()
                .ForMember(dest => dest.ProductName, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Note, opt => opt.MapFrom(src => src.Note))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                .ForMember(dest => dest.VitaminsId, opt => opt.MapFrom(src => src.VitaminProducts
                    .Select(p => p.VitaminId)));

            CreateMap<Report, ReportModel>()
                .ForMember(dest => dest.Created, opt => opt.MapFrom(src => src.Created))
                .ForMember(dest => dest.UserId, opt => opt.MapFrom(src => src.UserId))
                .ForMember(dest => dest.VitaminsId, opt => opt.MapFrom(src => src.VitaminReports
                    .Select(v => v.IdVitamin)));

            CreateMap<User, UserModel>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Gender, opt => opt.MapFrom(src => src.Gender))
                .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email))
                .ForMember(dest => dest.Promocode, opt => opt.MapFrom(src => src.Promocode))
                .ForMember(dest => dest.BirthDate, opt => opt.MapFrom(src => src.BirthDate))
                .ForMember(dest => dest.Height, opt => opt.MapFrom(src => src.Height))
                .ForMember(dest => dest.Weight, opt => opt.MapFrom(src => src.Weight))
                .ForMember(dest => dest.Phone, opt => opt.MapFrom(src => src.Phone))
                .ForMember(dest => dest.ReportIds, opt => opt.MapFrom(src => src.Reports.
                    Select(r => r.Id)));

            CreateMap<Vitamin, VitaminModel>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Unit, opt => opt.MapFrom(src => src.Unit))
                .ForMember(dest => dest.DailyStandart, opt => opt.MapFrom(src => src.DailyStandart))
                .ForMember(dest => dest.DailyUserVolume, opt => opt.MapFrom(src => src.DailyUserVolume))
                .ForMember(dest => dest.EffectsOnTheBody, opt => opt.MapFrom(src => src.EffectsOnTheBody))
                .ForMember(dest => dest.NutrionRecommendations, opt => opt.MapFrom(src => src.NutrionRecommendations));
        }
    }
}
