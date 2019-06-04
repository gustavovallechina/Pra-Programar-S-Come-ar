Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Digite a duração em minutos:")
        Dim minutos As Int32 = Int32.Parse(Console.ReadLine())
        Dim horaInicial, horaFinal As DateTime
        Dim p() As Process

        'Atribui à variável o instante atual
        horaInicial = DateTime.Now

        'Atribui à variavel o valor de horaInicial
        'acrescida dos minutos informados pelo usuário 
        horaFinal = horaInicial.AddMinutes(minutos)

        While horaInicial < horaFinal
            horaInicial = DateTime.Now

            'Verifica se a hora é igual nas duas variáveis
            If horaInicial.Hour = horaFinal.Hour Then

                'se sim, verifica se os minitos são iguais nas duas variáveis
                If horaInicial.Minute = horaFinal.Minute Then

                    'pega o processo desejado pelo nome
                    p = Process.GetProcessesByName("excel")

                    'na primeira ocorrência, mata o processo, ou seja fecha
                    'o programa
                    p(0).Kill()

                    horaFinal = horaInicial
                End If
            End If
        End While

    End Sub
End Module
