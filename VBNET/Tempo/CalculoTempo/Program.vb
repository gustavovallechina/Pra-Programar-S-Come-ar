Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Digite a dura��o em minutos:")
        Dim minutos As Int32 = Int32.Parse(Console.ReadLine())
        Dim horaInicial, horaFinal As DateTime
        Dim p() As Process

        'Atribui � vari�vel o instante atual
        horaInicial = DateTime.Now

        'Atribui � variavel o valor de horaInicial
        'acrescida dos minutos informados pelo usu�rio 
        horaFinal = horaInicial.AddMinutes(minutos)

        While horaInicial < horaFinal
            horaInicial = DateTime.Now

            'Verifica se a hora � igual nas duas vari�veis
            If horaInicial.Hour = horaFinal.Hour Then

                'se sim, verifica se os minitos s�o iguais nas duas vari�veis
                If horaInicial.Minute = horaFinal.Minute Then

                    'pega o processo desejado pelo nome
                    p = Process.GetProcessesByName("excel")

                    'na primeira ocorr�ncia, mata o processo, ou seja fecha
                    'o programa
                    p(0).Kill()

                    horaFinal = horaInicial
                End If
            End If
        End While

    End Sub
End Module
