using System.ComponentModel;

namespace Agendaqui.Areas.Clinica.Enum
{
    public enum TipoDeDocumento
    {
        Error,

        /// <summary>
        /// CPF
        /// </summary>
        [Description("CPF")]
        CPF,

        /// <summary>
        /// CNPJ
        /// </summary>
        [Description("CNPJ")]
        CNPJ,
    }
}
