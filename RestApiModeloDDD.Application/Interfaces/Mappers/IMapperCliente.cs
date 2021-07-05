using RestApiModeloDDD.Application.DTOs;
using RestApiModeloDDD.Domain.Entitys;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestApiModeloDDD.Application.Interfaces.Mappers
{
    public interface IMapperCliente
    {
        Cliente MapperDTOToEntity(ClienteDTO clienteDTO);

        IEnumerable<ClienteDTO> MapperListClientesDTO(IEnumerable<Cliente> clientes);

        ClienteDTO MapperEntityToDTO(Cliente cliente);
    }
}
