using System.Collections.Generic;

namespace sistema_reporte_ciudadano.Models
{
    public class User
    {
        public int Id{ get; set;}
        public int IdZone{get; set;}
        public string Name{get; set;}
        public string Photo{get; set;}
        public string Email{get; set;}
        public string Password{get; set;}
        public List<Incident> Incidents {get; set;}
    }
}