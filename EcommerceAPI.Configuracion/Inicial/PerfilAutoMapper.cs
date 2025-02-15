﻿using AutoMapper;
using EcommerceAPI.Comunes.Classes.Contracts.Compra;
using EcommerceAPI.Infraestructura.Database.Entities.Cliente;

namespace EcommerceAPI.Configuracion.Inicial
{
    public class PerfilAutoMapper : Profile
    {
        public PerfilAutoMapper()
        {
            CreateMap<ClienteEntity, ClienteContract>().ReverseMap();

/*            CreateMap<ClienteContract, ClienteEntity>()
                    .ForMember(dest => dest.id_cliente, opt => opt.MapFrom(src => src.id_cliente))
                    .ForMember(dest => dest.nombre, opt => opt.MapFrom(src => src.nombre))
                    .ForMember(dest => dest.contrasena, opt => opt.MapFrom(src => src.contrasena))
                    .ForMember(dest => dest.correo, opt => opt.MapFrom(src => src.correo))
                    .ForMember(dest => dest.direccioncliente, opt => opt.MapFrom(src => src.direccioncliente))
                    .ForMember(dest => dest.telefono, opt => opt.MapFrom(src => src.telefono));*/
        }
    }
}
