using System;
using System.Collections.Generic;


namespace SistemaDeAgendamentoDeConslta.Entities
{
    abstract class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; private set; }
        public string Sobrenome { get; private set; }
        public DateTime Nascimento { get; private set; }
        public string Endereco { get; private set; }
        public int TelefoneCelular { get; private set; }

        public List<Pessoa> _paciente = new List<Pessoa>();
        //Construtores
        public Pessoa()
        {

        }

        public Pessoa(int id, string nome, string sobrenome, DateTime nascimento, string endereco, int telefoneCelular)
        {
            Id = id;
            Nome = nome;
            Sobrenome = sobrenome;
            Nascimento = nascimento;
            Endereco = endereco;
            TelefoneCelular = telefoneCelular;
        }

        public virtual void Salvar(List<Pessoa> pessoas)
        {
            int i = 0;
            foreach (Pessoa item in pessoas)
            {
                _paciente.Add(pessoas[i]);
                i++;
            }
            pessoas.Clear();

        }

    }
}
