using RestApiModeloDDD.Application.DTOs;
using RestApiModeloDDD.Application.Interfaces.Mappers;
using RestApiModeloDDD.Domain.Entitys;
using System.Collections.Generic;
using System.Linq;

namespace RestApiModeloDDD.Infrastructure.CrossCuting.Mapper
{
    public class MapperProduto : IMapperProduto
    {
        public Produto MapperDTOToEntity(ProdutoDTO produtoDTO)
        {
            Produto produto = new Produto()
            {
                Id = produtoDTO.Id,
                Nome = produtoDTO.Nome,
                Valor = produtoDTO.Valor,
                //IsActive = produtoDTO.NãoTemEsseValor
            };

            return produto;
        }

        public ProdutoDTO MapperEntityToDTO(Produto produto)
        {
            return new ProdutoDTO()
            {
                Id = produto.Id,
                Nome = produto.Nome,
                Valor = produto.Valor,
                //NãoTemEsseValor = produtoDTO.IsActive
            };
        }

        public IEnumerable<ProdutoDTO> MapperListProdutosDTO(IEnumerable<Produto> produtos)
        {
            return produtos.Select(item => new ProdutoDTO()
            {
                Id = item.Id,
                Nome = item.Nome,
                Valor = item.Valor
            });
        }
    }
}