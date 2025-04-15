using Agendaqui.Areas.Clinica.Enum;

namespace Agendaqui.Areas.Clinica.ViewModel.Profissional
{
    public class ProfissionalViewModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Usuario { get; set; }
        public string NumeroDeDocumento { get; set; }
        public TipoDeDocumento TipoDeDocumento { get; set; }
        public string Email { get; set; }
        public Status Status { get; set; }
        public DateTime DataInicioRelacionamento { get; set; }
        public DateTime? DataFimRelacionamento { get; set; }
        public string? MotivoFimRelacionamento { get; set; }
    }
}
