using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaDeAgendamentoDeConslta.Entities
{
    class Consulta
    {
        public int IdConsulta { get; set; }
        public DateTime DataHora { get; set; }
        public string Status { get; set; }
        public int IdMedico { get; set; }
        public int IdPaciente { get; set; }
        public string Convenio { get; set; }

        //Construtores

        public Consulta()
        {

        }

        public Consulta(int idConsulta, DateTime dataHora, string status, int idMedico, int idPaciente, string convenio)
        {
            IdConsulta = idConsulta;
            DataHora = dataHora;
            Status = status;
            IdMedico = idMedico;
            IdPaciente = idPaciente;
            Convenio = convenio;
        }

        // Métodos

        public void AtualizarStatus(List<Consulta> atualizarStatusConsulta, int idConsulta, string novoStatus)
        {
            atualizarStatusConsulta.Find(x => x.IdConsulta == idConsulta);
            foreach (Consulta item in atualizarStatusConsulta)
            {
                item.Status = novoStatus;
            }
        }
    }
}
