using RestApiModeloDDD.Application.DTOs;
using RestApiModeloDDD.Application.Interfaces;
using RestApiModeloDDD.Application.Interfaces.Mappers;
using RestApiModeloDDD.Domain.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestApiModeloDDD.Application
{
    public class ApplicationServiceProduto : IApplicationServiceProduto
    {
        private readonly IServiceProduto serviceProduto;
        private readonly IMapperProduto mapperProduto;

        public ApplicationServiceProduto(IServiceProduto serviceProduto, IMapperProduto mapperProduto)
        {
            this.serviceProduto = serviceProduto;
            this.mapperProduto = mapperProduto;
        }

        public void Add(ProdutoDTO produtoDTO)
        {
            var produto = mapperProduto.MapperDTOToEntity(produtoDTO);
            serviceProduto.Add(produto);
            Console.WriteLine("Add produto");
        }

        public IEnumerable<ProdutoDTO> GetAll()
        {
            var produtos = serviceProduto.GetAll();
            return mapperProduto.MapperListProdutosDTO(produtos);
        }

        public ProdutoDTO GetById(int id)
        {
            var produto = serviceProduto.GetById(id);
            return mapperProduto.MapperEntityToDTO(produto);
        }

        public void Remove(ProdutoDTO produtoDTO)
        {
            var produto = mapperProduto.MapperDTOToEntity(produtoDTO);
            serviceProduto.Remove(produto);
            Console.WriteLine("Produto removido");
        }

        public void Update(ProdutoDTO produtoDTO)
        {
            var produto = mapperProduto.MapperDTOToEntity(produtoDTO);
            serviceProduto.Update(produto);
            Console.WriteLine("Produto Atualizado");
        }
    }
}
