using ApiDoctoresPruebaCasa.Data;
using ApiDoctoresPruebaCasa.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiDoctoresPruebaCasa.Repositories
{
    public class RepositoryDoctores
    {
        private DoctoresContext context;

        public RepositoryDoctores(DoctoresContext context)
        {
            this.context = context;
        }

        public List<Doctor> GetDoctores()
        {
            return this.context.Doctores.ToList();
        }

        public Doctor FindDoctor(int id)
        {
            return this.context.Doctores.Where(x => x.NumDoctor == id.ToString()).FirstOrDefault();
        }

        public void DeleteDoctor(int id)
        {
            Doctor doc = this.FindDoctor(id);
            this.context.Doctores.Remove(doc);
            this.context.SaveChanges();
        }

        public void InsertDoctor(string HospitalCod, string doctorCod, string apellido, string especialidad, int salario, string imagen)
        {
            Doctor doc = new Doctor()
            {
                Cod_Hospital = HospitalCod,
                NumDoctor = doctorCod,
                Apellido = apellido,
                Especialidad = especialidad,
                Salario = salario,
                Imagen = imagen
            };
            this.context.Doctores.Add(doc);
            this.context.SaveChanges();
        }

        public void UpdateDoctor(string cod_Hospital, string numDoctor, string apellido, string especialidad, int salario, string imagen)
        {
            Doctor doc = new Doctor()
            {
                Cod_Hospital = cod_Hospital,
                NumDoctor = numDoctor,
                Apellido = apellido,
                Especialidad = especialidad,
                Salario = salario,
                Imagen = imagen
            };
            this.context.Doctores.Update(doc);
            this.context.SaveChanges();
        }
    }
}
