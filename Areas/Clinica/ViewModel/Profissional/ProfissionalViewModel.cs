using Agendaqui.Areas.Clinica.Enum;
using System.ComponentModel.DataAnnotations;

namespace Agendaqui.Areas.Clinica.ViewModel.Profissional
{
    public class ProfissionalViewModel
    {
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public string NumeroDeDocumento { get; set; }

        [Required]
        public TipoDeDocumento TipoDeDocumento { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public Status Status { get; set; }

        public DateTime DataInicioRelacionamento { get; set; }

        public DateTime? DataFimRelacionamento { get; set; }

        public string? MotivoFimRelacionamento { get; set; }

        [Required]
        public string Usuario { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare("Senha", ErrorMessage = "A senha e a confirmação não coincidem.")]
        public string ConfirmarSenha { get; set; }
    }
}
