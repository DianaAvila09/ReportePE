//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ReportePE.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class PRENSAS_Cat_NombresLinea
    {
        public int IdPrensa { get; set; }
        public string Descripcion { get; set; }
        public string Trabajando { get; set; }
        public string Alias { get; set; }
        public string Maquina { get; set; }
        public string Tipo_Turno { get; set; }
        public string Area { get; set; }
        public Nullable<bool> ReporteoSAP { get; set; }
        public Nullable<int> MaxReport { get; set; }
        public Nullable<int> VelocidadGenerica { get; set; }
    }
}
