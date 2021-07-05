using RestApiModeloDDD.Application.DTOs;
using RestApiModeloDDD.Domain.Entitys;
using System.Collections.Generic;

namespace RestApiModeloDDD.Application.Interfaces.Mappers
{
    public interface IMapperProduto
    {
        Produto MapperDTOToEntity(ProdutoDTO produtoDTO);

        IEnumerable<ProdutoDTO> MapperListProdutosDTO(IEnumerable<Produto> produtos);

        ProdutoDTO MapperEntityToDTO(Produto produto);
    }
}