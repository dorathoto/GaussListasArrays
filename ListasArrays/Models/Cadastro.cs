using Exemplos.Models.Enums;

namespace Exemplos.Models
{
    public class Cadastro
    {
        public int Id { get; set; }
        public TipoFuncao Funcao { get; set; }
        public string Nome { get; set; }

        public decimal Salario { get; set; }
    }
}
