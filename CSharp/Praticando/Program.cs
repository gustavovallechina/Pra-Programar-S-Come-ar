using System;

namespace Praticando
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BEM VINDO AO ENFORCANDO!");
            Console.WriteLine();
            Console.WriteLine("------------------------");
            Console.WriteLine("|      O               |");
            Console.WriteLine("|      |               |");
            Console.WriteLine("|     <|>              |");
            Console.WriteLine("|      |               |");
            Console.WriteLine("|      |               |");
            Console.WriteLine("|     ///              |");
            Console.WriteLine("------------------------");
            Console.WriteLine();
            Console.WriteLine("DIGITE A PALAVRA A SER VERIFICADA:");
            string palavra = Console.ReadLine();
            string[] resultado = new string[palavra.Length];

            // quantidade de erros, quantidade de acertos, verifica se todas as posições preenchidas são letras
            sbyte erros = 0, acertos = 0, checar = 0;          
            
            //Limpa a tela depois que a palavra foi digitada
            Console.Clear();

            Console.WriteLine("Digite uma letra sempre que for esperado:");
            while (erros != 7 && checar != resultado.Length)
            {
                char letra = char.Parse(Console.ReadLine());

                //verifica ocorrência da letra no STRING original
                int ocorrencias = palavra.IndexOf(letra);

                //Caso negativo, incrementa a variável erros
                if (ocorrencias == -1)
                {
                    erros++;
                }
                else //senão incrementa a variável acertos
                {
                    acertos++;

                    //percorre o STRING original(palavra) e à medida que encontrar a letra
                    for (int i = 0; i < palavra.Length; i++)
                    {
                        if (palavra[i].ToString() == letra.ToString())
                        {
                            //preenche a posição correspondente no vetor resultado
                            resultado[i] = letra.ToString();

                            //percorre o vetor resultado verificando se a posição preenchida é uma letra
                            if (resultado[i]!= null && resultado[i]!= "_ ")
                            {
                                //incrementa a variável checar indicando que a posição contém uma letra
                                checar++;
                            }
                        }
                        //senão, preenche a posição do vetor resultado com _ , indicando que a letra não corresponde 
                        else if (resultado[i] is null)
                        {
                            resultado[i] = "_ ";

                        }
                        
                    }
                }

                //imprime o conteúdo do vetor
                foreach (string item in resultado)
                {
                    Console.Write(item);

                }
                Console.WriteLine();

                //se erros vale 7
                if (erros == 7)
                {
                    //forca
                    Console.WriteLine("VOCÊ FOI ENFORCADO!");
                }

                //senão se checar for igual ao tamanho do vetor resultado
                //significa que todas as posições são letras
                else if (checar == resultado.Length)
                {
                    //e o jogador acertou a palavra
                    Console.WriteLine("VOCÊ GANHOU!");
                }
                else
                {
                    //imprime quantidade de erros e acertos
                    Console.WriteLine("Erros:{0}, Acertos:{1}", erros, acertos);
                }
            }
        }
    }

}


