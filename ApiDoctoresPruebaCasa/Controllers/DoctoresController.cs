using ApiDoctoresPruebaCasa.Models;
using ApiDoctoresPruebaCasa.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiDoctoresPruebaCasa.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctoresController : ControllerBase
    {
        public RepositoryDoctores repo;

        public DoctoresController(RepositoryDoctores repo)
        {
            this.repo = repo;
        }

        [HttpGet]
        public ActionResult<List<Doctor>> GetDoctores()
        {
            List<Doctor> doctores = this.repo.GetDoctores();
            return doctores;
        }

        [HttpGet("{id}")]
        public ActionResult<Doctor> FindDoctor(int id)
        {
            Doctor doc = this.repo.FindDoctor(id);
            return doc;
        }

        [HttpDelete]
        [Route("[action]/{id}")]
        public ActionResult DeleteDoctor(int id)
        {
            this.repo.DeleteDoctor(id);
            return Ok();
        }

        [HttpPost]
        public ActionResult InsertDoctor(Doctor doc)
        {
            this.repo.InsertDoctor(doc.Cod_Hospital, doc.NumDoctor, doc.Apellido, doc.Especialidad, doc.Salario, doc.Imagen);
            return Ok();
        }

        [HttpPut]
        public ActionResult UpdateDoctor(Doctor doc)
        {
            this.repo.UpdateDoctor(doc.Cod_Hospital, doc.NumDoctor, doc.Apellido, doc.Especialidad, doc.Salario, doc.Imagen);
            return Ok();
        }
    }
}
