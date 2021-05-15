using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaDeAgendamentoDeConslta.Entities
{
    class Paciente : Pessoa
    {
        public Medico DadosMedico { get; set; }
        private List<Consulta> _consulta = new List<Consulta>();


        //construtores
        public Paciente()
        {
            
        }

        public Paciente(int idPacienteAssociacao)
        {
            Id = idPacienteAssociacao;
        }

        public Paciente(Medico dadosMedico, int id, string nome, string sobrenome, DateTime nascimento, string endereco, int telefoneCelular) : base(id, nome, sobrenome, nascimento, endereco, telefoneCelular)
        {
            DadosMedico = dadosMedico;
        }

        //Métodos

        public override void Salvar(List<Pessoa> pessoas)
        {
            base.Salvar(pessoas);
        }

        public void Excluir(List<Pessoa> pessoa, int apagar)
        {
            pessoa.Remove(pessoa.Find(x => x.Id == apagar));
        }

        public void AgendarConsulta(List<Consulta> consulta)
        {
            int i = 0;
            foreach (Consulta item in consulta)
            {
                _consulta.Add(consulta[i]);
                i++;
            }
            consulta.Clear();

        }
    }

}
