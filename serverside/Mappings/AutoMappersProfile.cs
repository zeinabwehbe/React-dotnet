using AutoMapper;
using serverside.Models.DTOs;
using serverside.Models.Domain;
namespace serverside.Mappings
{
    public class AutoMappersProfile: Profile
    {
        //inside constructors we create the mapping
        /*    public AutoMappersProfile()
            {
                CreateMap<UserDto, UserDomain>()
                    .ForMember(x => x.MypropertyDomain, opt => opt.MapFrom(x => x.MypropertyDto))
                    .ReverseMap();

            }

            public class UserDto {
                public string MypropertyDto { get; set; }

            }
            public class UserDomain {
                public string MypropertyDomain { get; set; }
            }*/
        public AutoMappersProfile()
        {
            CreateMap<Users, UserDto>().ReverseMap();
            CreateMap<AddUserRequestDto, Users>().ReverseMap();    //this will be used to convert DTO into the domain model
            CreateMap<UpdateUserRequestDto, Users>().ReverseMap();

            CreateMap<Posts, PostDto>().ReverseMap();
            CreateMap<AddPostRequestDto, Posts>().ReverseMap();    //this will be used to convert DTO into the domain model

        }
    }
}
