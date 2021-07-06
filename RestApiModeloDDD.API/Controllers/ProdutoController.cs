using Microsoft.AspNetCore.Mvc;
using RestApiModeloDDD.Application.DTOs;
using RestApiModeloDDD.Application.Interfaces;
using System;

namespace RestApiModeloDDD.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProdutoController : Controller
    {
        private readonly IApplicationServiceProduto applicationServiceProduto;

        public ProdutoController(IApplicationServiceProduto applicationServiceProduto)
        {
            this.applicationServiceProduto = applicationServiceProduto;
        }

        /// <summary>
        /// GetById
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public ActionResult<string> GetById(int id)
        {
            return Ok(applicationServiceProduto.GetById(id));
        }

        /// <summary>
        /// Post
        /// </summary>
        /// <param name="clienteDTO"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Post([FromBody] ProdutoDTO produtoDTO)
        {
            try
            {
                if (produtoDTO is null)
                {
                    return NotFound();
                }
                applicationServiceProduto.Add(produtoDTO);
                return Ok("produtoDTO Cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Put
        /// </summary>
        /// <param name="produtoDTO"></param>
        /// <returns></returns>
        [HttpPut]
        public ActionResult Put([FromBody] ProdutoDTO produtoDTO)
        {
            try
            {
                if (produtoDTO is null) return NotFound();

                applicationServiceProduto.Update(produtoDTO);
                return Ok("Cliente atualizado com sucesso");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Delete
        /// </summary>
        /// <param name="clienteDTO"></param>
        /// <returns></returns>
        [HttpDelete]
        public ActionResult Delete([FromBody] ProdutoDTO produtoDTO)
        {
            try
            {
                if (produtoDTO is null) return NotFound();

                applicationServiceProduto.Remove(produtoDTO);

                return Ok("Cliente Removido com sucesso!");
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Key
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Key([FromHeader] string key)
        {
            return Ok("key = " + key);
        }
    }
}