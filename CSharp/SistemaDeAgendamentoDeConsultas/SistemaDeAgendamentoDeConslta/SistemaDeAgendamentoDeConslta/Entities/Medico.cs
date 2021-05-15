using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaDeAgendamentoDeConslta.Entities
{
    class Medico : Pessoa
    {
        public string Especialidade { get; set; }
        public string Convenio { get; set; }

        //Construtores
        public Medico()
        {

        }

        public Medico(int idMedicoAssociacao)
        {
            Id = idMedicoAssociacao;
        }
        public Medico(string especialidade, string convenio, int id, string nome, string sobrenome, DateTime nascimento, string endereco, int telefoneCelular):base(id,nome,sobrenome,nascimento,endereco,telefoneCelular)
        {
            Especialidade = especialidade;
            Convenio = convenio;
        }

        //Métodos
        public override void Salvar(List<Pessoa> pessoas)
        {
            base.Salvar(pessoas);
        }

    }
}
