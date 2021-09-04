using System.ComponentModel.DataAnnotations;

namespace eventosAPI.Models
{
    public class Evento
    {
        public int Id {get; set;}

        [Required(ErrorMessage = "O campo NomeEvento é obrigatório!")]
        //[Range(3,250, ErrorMessage = "O campo nomeEvento precisa ter no minimo três caracteres")]
        public string NomeEvento {get; set;}

        [Required(ErrorMessage = "O campo localEvento é obrigatório!")]
        public string LocalEvento {get; set;}

        [Required(ErrorMessage = "O campo DataEvento é obrigatório!")]
        public string DataEvento {get; set;}
    }
}