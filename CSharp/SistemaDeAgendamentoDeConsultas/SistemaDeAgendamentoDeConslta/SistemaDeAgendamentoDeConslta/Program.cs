using System;
using System.Globalization;
using System.Collections.Generic;
using SistemaDeAgendamentoDeConslta.Entities;
using SistemaDeAgendamentoDeConslta.Entities.Enums;

namespace SistemaDeAgendamentoDeConslta
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sistema de Agendamento de Consultas");
            Console.WriteLine("-------------------------------------");
            List<Consulta> consultas = new List<Consulta>();
            List<Pessoa> pessoa = new List<Pessoa>();
            Paciente pacientes = new Paciente();
            Medico medicos = new Medico();
            bool realizarCadastro = true;
            bool agendarConsulta = true;
            try
            {
                while (realizarCadastro)
                {
                    Console.WriteLine("O que você deseja cadastrar?");
                    Console.WriteLine("1-Paciente/2-Medico");
                    int opcao = int.Parse(Console.ReadLine());

                    Console.Write("Digite o id da pessoa: ");
                    int id = int.Parse(Console.ReadLine());
                    Console.Write("Digite o nome: ");
                    string nome = Console.ReadLine();
                    Console.Write("Digite o sobrenome: ");
                    string sobrenome = Console.ReadLine();
                    Console.Write("Digite a data de nascimento(dia/mês/ano): ");
                    DateTime nascimento = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    Console.Write("Digite o endereço: ");
                    string endereço = Console.ReadLine();
                    Console.Write("Digite o telefone celular: ");
                    int telefoneCelular = int.Parse(Console.ReadLine());


                    if (opcao == 2)
                    {
                        int idMedicoCadastro = id;
                        Console.Write("Digite a especialidade: ");
                        string especialidade = Console.ReadLine();
                        Console.Write("Digite o convenio: ");
                        string convenio = Console.ReadLine();

                        pessoa.Add(new Medico(especialidade, convenio, id, nome, sobrenome, nascimento, endereço, telefoneCelular));

                        

                    }
                    else
                    {
                        Console.Write("Digite o convenio: ");
                        string convenioPaciente = Console.ReadLine();
                        Console.Write("Digite o id do medico: ");
                        int idMedicoPaciente = int.Parse(Console.ReadLine());
                        Medico idMedico = new Medico(idMedicoPaciente);

                        pessoa.Add(new Paciente(idMedico, id, nome, sobrenome, nascimento, endereço, telefoneCelular));

                        
                    }

                    Console.Write("Deseja realizar outro cadastro? ");
                    char letra = char.Parse(Console.ReadLine());
                    if (letra == 'N')
                    {
                        realizarCadastro = false;
                        pacientes.Salvar(pessoa);
                        medicos.Salvar(pessoa);
                    }
                }


                Console.Write("Deseja excluir algum item já cadastrado? ");
                char letraExcluir = char.Parse(Console.ReadLine());
                if (letraExcluir == 'S')
                {
                    Console.Write("Digite o id que deseja excluir: ");
                    int idExcluir = int.Parse(Console.ReadLine());


                    pacientes.Excluir(pessoa, idExcluir);
                }
                while (agendarConsulta)
                {
                    Console.Write("Deseja agendar consulta para algum paciente? ");
                    char agendar = char.Parse(Console.ReadLine());
                    if (agendar == 'S')
                    {
                        Console.Write("Digite o id da consulta: ");
                        int idDaConsulta = int.Parse(Console.ReadLine());
                        Console.Write("Digite a data e hora da consulta:(dia/mês/ano hora:minutos) ");
                        DateTime dataHoraConsulta = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
                        Console.Write("Digite o id do medico: ");
                        int idDoMedico = int.Parse(Console.ReadLine());
                        Console.Write("Digite o id do paciente: ");
                        int idDoPaciente = int.Parse(Console.ReadLine());
                        Console.Write("Digite o convenio: ");
                        string convenio = Console.ReadLine();
                        Console.Write("Digite o status: ");
                        string status = Console.ReadLine();
                        StatusConsulta statusConsulta = Enum.Parse<StatusConsulta>(status.ToString());

                        consultas.Add(new Consulta(idDaConsulta, dataHoraConsulta, status, idDoMedico, idDoPaciente, convenio));

                        pacientes.AgendarConsulta(consultas);

                        Console.Write("Deseja atualizar situação da consulta para algum paciente? ");
                        char situacao = char.Parse(Console.ReadLine());
                        if (situacao == 'S')
                        {
                            Consulta consultaAtualizar = new Consulta();
                            Console.Write("Digite o novo status da consulta: ");
                            string novoStatus = Console.ReadLine();
                            statusConsulta = Enum.Parse<StatusConsulta>(novoStatus.ToString());
                            consultaAtualizar.AtualizarStatus(consultas, idDaConsulta, novoStatus);
                        }

                    }
                    else
                    {
                        agendarConsulta = false;
                    }
                }
            }
            catch(Exception ex)
            {
                SacException sac = new SacException(ex.Message);
            }
            Console.ReadLine();
        }

    }
}

