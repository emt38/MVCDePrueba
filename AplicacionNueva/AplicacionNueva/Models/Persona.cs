using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MagnaDB;
using System.ComponentModel.DataAnnotations;

namespace AplicacionNueva.Models
{
    public class Persona : TableModel<Persona>
    {
        protected override string ConnectionString
        {
            get { return MvcApplication.connectionString; }
        }
        protected override MagnaKey Key
        {
            get { return this.MakeKey(c => c.Id); }
        }
        protected override string TableName
        {
            get { return "Personas"; }
        }

        [Identity]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        
        
        [DateTimeType(DateTimeSpecification.Date)]
        [ColumnName("FechaNacimiento")]
        [DataType(DataType.Date)]
        public DateTime? Fecha { get; set; }

        [DMLIgnore]
        public int Edad { get; set; }
    }
}