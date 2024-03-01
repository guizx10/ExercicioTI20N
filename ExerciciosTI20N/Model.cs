using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosTI20N
{
    class Model
    {
        //Construtor
        public Model()
        {


        }//fim do metodo construtor 

        //Exercicio 01: Faça um programa que imprima os números de 1 ao 10. 
        public string ExercicioUm()
        {
            string resultado = ""; 

            for(int i=0; i< 10; i++)
            {

                resultado += "\n" + (i + 1);

            }

            return resultado;
        }//fim do Método 

        //Faça um programa que imprima os números pares de 1 a 20. 
        public string ExercicioDois()
        {


            string resultado = ""; 

            for(int i=0; i < 20; i++)
            {
                if ((i + 1) % 2 == 0)
                {


                    resultado += "\n" + (i + 1);
                }//fim do if
            }//fim do for 


            return resultado;
        }//fim do exercicio dois 


        //Exercício 3: Faça um programa que calcule a soma dos números de 1 a 100. 
        public int ExercicioTres()
        {


            int soma = 0; 

            for(int i=1; i < 100; i++)
            {
               soma += i;
            }//fim do for
            return soma;
        }//fim do exercicio tres


        //Exercício 4: Faça um programa que imprima os múltiplos de 5 de 1 a 50. 
        public string ExercicioQuatro()
        {

            string resultado = ""; 

            for(int i=1; i <= 50; i ++)
            {
               if ((i + 1) % 5 == 0)
                {
                    resultado += "\n" + (i + 1);
                }//fim do if 

            }//fim do for

            return resultado;
        }//fim do exercicio quatro 


        //Exercício 5: Faça um programa que peça ao usuário um número e imprima se é par ou impar.
        public string ExercicioCinco(int num)
        {
            if(num % 2 == 0)
            {
                return num + " é Par";
            }
            else
            {
                return num + " é Impar"; 
            }
        }//fim do metodo
         
       

    }//fim da classe
}//fim do projeto 
