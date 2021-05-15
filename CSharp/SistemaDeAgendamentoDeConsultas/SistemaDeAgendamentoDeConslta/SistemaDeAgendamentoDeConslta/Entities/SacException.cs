using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaDeAgendamentoDeConslta.Entities
{
    class SacException : Exception
    {
        public SacException(string mensagem) : base(mensagem)
        {
            if (mensagem == "Input string was not in a correct format.")
            {
                Console.WriteLine("Verifique a informação digitada.");
            }
            else if (mensagem.Contains("was not recognized as a valid DateTime."))
            {
                Console.WriteLine("Formato de data inválido.");
            }
            else
            {
                Console.WriteLine("Status de consulta inválido.");
            }
        }
    }
}
