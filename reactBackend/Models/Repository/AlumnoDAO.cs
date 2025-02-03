using reactBackend.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reactBackend.Models.Repository
{
    public class AlumnoDAO
    {
        #region Context
        public AlumnoRegistroContext contexto = new AlumnoRegistroContext();
        #endregion

        #region Select All
         public List<Alumno> SelectAll()
        {
            var alumno = contexto.Alumnos.ToList<Alumno>();
            return alumno;
        }
        #endregion

        #region Select by ID

        public Alumno? GetById(int id) {
           var alumno = contexto.Alumnos.Where(x => x.Id == id).FirstOrDefault();
            return alumno == null ? null : alumno;
        }
        #endregion

    }
}
