using System.ComponentModel.DataAnnotations.Schema;
namespace sistema_reporte_ciudadano.Models
{
    public class  Incident
    {
        public int Id{ get; set;}
        public int IdZone{get; set;}
        public string Date{get; set;}
        public string Msg{get; set;}
        public string Media{get; set;}
        public int Votes{get; set;}

        [ForeignKey("User")]
        public int IdUser{get; set;}
        public User User{get; set;}
    }
}