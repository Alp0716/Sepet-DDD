using AutoMapper;
using Domain.Command;
using Domain.Models;

namespace Application.AutoMapper
{
    public   class AutoMapperDto:Profile
    {
        public AutoMapperDto()
        {
            CreateMap<User, UserDto>().ReverseMap();  
            CreateMap<CreateUserCommand, User>().ReverseMap();
            CreateMap<User, DeleteUserCommand>().ReverseMap();
            CreateMap<User, UpdateUserCommand>().ReverseMap();
            CreateMap<Product, ProductDto>().ReverseMap();
            CreateMap<Product, CreateProductCommand>().ReverseMap();
            CreateMap<Product, DeleteProductCommand>().ReverseMap();
            CreateMap<Product, UpdateProductCommand>().ReverseMap();
            CreateMap<Sepet, SepetDto>().ReverseMap();
            CreateMap<Sepet, CreateSepetCommand>().ReverseMap();
            CreateMap<Sepet, DeleteSepetCommand>().ReverseMap();
            CreateMap<Sepet, UpdateSepetCommand>().ReverseMap();

        }
    }
}
