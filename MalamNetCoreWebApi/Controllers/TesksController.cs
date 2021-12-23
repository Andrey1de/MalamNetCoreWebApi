﻿using MalamNetCoreWebApi.Models;
using MalamNetCoreWebApi.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MalamNetCoreWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TesksController : ControllerBase
    {
        private readonly IDataAccessService dataAccessService;

        public TesksController(IDataAccessService _dataAccessService)
        {
            dataAccessService = _dataAccessService;
        }
        // GET: api/<TaskDosController>
        [HttpGet]
        public List<TaskDo> Get()
        {
            return dataAccessService.Tasks.Values.ToList();
        }

        // GET api/<TaskDosController>/5
        [HttpGet("{id}")]
        public TaskDo Get(int id)
        {
            return dataAccessService.GetTaskDo(id);
        }
        //// POST api/<TesksController>
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/<TesksController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<TesksController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
