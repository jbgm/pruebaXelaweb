//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CursosEstudiante
{
    using System;
    using System.Collections.Generic;
    
    public partial class Curso
    {
        public Curso()
        {
            this.Asignaciones = new HashSet<Asignacion>();
            this.Tareas = new HashSet<Tarea>();
        }
    
        public int IdCurso { get; set; }
        public string Nombre { get; set; }
    
        public virtual ICollection<Asignacion> Asignaciones { get; set; }
        public virtual ICollection<Tarea> Tareas { get; set; }
    }
}