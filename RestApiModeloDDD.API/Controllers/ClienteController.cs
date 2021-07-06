using Microsoft.AspNetCore.Mvc;
using RestApiModeloDDD.Application.DTOs;
using RestApiModeloDDD.Application.Interfaces;
using System;
using System.Collections.Generic;

namespace RestApiModeloDDD.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ClienteController : Controller
    {
        private readonly IApplicationServiceCliente applicationServiceCliente;

        public ClienteController(IApplicationServiceCliente applicationServiceCliente)
        {
            this.applicationServiceCliente = applicationServiceCliente;
        }

        /// <summary>
        /// GetAll
        /// </summary>
        /// <returns></returns>
        [HttpGet("Clientes")]
        public ActionResult<IEnumerable<ClienteDTO>> Clientes()
        {
            return Ok(applicationServiceCliente.GetAll());
        }

        /// <summary>
        /// GetById
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public ActionResult<string> GetById(int id)
        {
            return Ok(applicationServiceCliente.GetById(id));
        }

        /// <summary>
        /// PostClient
        /// </summary>
        /// <param name="clienteDTO"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult PostClient([FromBody] ClienteDTO clienteDTO)
        {
            try
            {
                if (clienteDTO is null)
                {
                    return NotFound();
                }
                applicationServiceCliente.Add(clienteDTO);
                return Ok("Cliente Cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// PutClient
        /// </summary>
        /// <param name="clienteDTO"></param>
        /// <returns></returns>
        [HttpPut]
        public ActionResult PutClient([FromBody] ClienteDTO clienteDTO)
        {
            try
            {
                if (clienteDTO is null) return NotFound();

                applicationServiceCliente.Update(clienteDTO);
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
        public ActionResult Delete([FromBody] ClienteDTO clienteDTO)
        {
            try
            {
                if (clienteDTO is null) return NotFound();

                applicationServiceCliente.Remove(clienteDTO);

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
        public ActionResult TesteKey([FromHeader] string key)
        {
            return Ok("key = " + key);
        }
    }
}