using RestApiModeloDDD.Application.DTOs;
using RestApiModeloDDD.Application.Interfaces.Mappers;
using RestApiModeloDDD.Domain.Entitys;
using System.Collections.Generic;
using System.Linq;

namespace RestApiModeloDDD.Infrastructure.CrossCuting.Mapper
{
    public class MapperCliente : IMapperCliente
    {
        public Cliente MapperDTOToEntity(ClienteDTO clienteDTO)
        {
            Cliente cliente = new Cliente()
            {
                Id = clienteDTO.Id,
                Nome = clienteDTO.Nome,
                SobreNome = clienteDTO.SobreNome,
                Email = clienteDTO.Email
            };

            return cliente;
        }

        public ClienteDTO MapperEntityToDTO(Cliente cliente)
        {
            var clienteDTO = new ClienteDTO()
            {
                Id = cliente.Id,
                Nome = cliente.Nome,
                SobreNome = cliente.SobreNome,
                Email = cliente.Email
            };

            return clienteDTO;
        }

        public IEnumerable<ClienteDTO> MapperListClientesDTO(IEnumerable<Cliente> clientes)
        {
            return clientes.Select(c => new ClienteDTO()
            {
                Id = c.Id,
                Nome = c.Nome,
                SobreNome = c.SobreNome,
                Email = c.Email
            });
        }
    }
}