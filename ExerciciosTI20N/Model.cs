using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters;
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
         
        //Exercicio 6: Faça um programa que peça ao usuario um número e imprima se é positivo, negativo ou zero. 
        public string ExercicioSeis(int num)
        {
            if(num < 0)
            {
                return num + " é Negativo";

            }
            else if (num > 0)
            {
                
                return num + " é Positivo";

            }
            else 
            {
                return num + " é zero";
            }
            
        }//fim do metodo 
       
        //Exercicio 7: Faça um programa que peça ao usuario um número e imprima a tabuada desse número
        public string ExercicioSete(int num)
        {

            string resultado = "";

            resultado += "\nTabuada de " + num;
            for (int i = 0; i <= 10; i++)
            {
                resultado += "\n" + num + " * " + i + " = " + (num * i);

            }//fim do for

            return resultado;   
        }//fim do metodo

        //Exercicio 8: Faça um programa que peça ao usúario um número e imprima os números de 1 até esse número.
        public string ExercicioOito(int num)
        {

            string resultado = "";

            for (int i = 0; i < num; i++)
            {

                resultado += "\n" + (i + 1);

            }

            return resultado;
        }//fim do metodo

        //Exercicio 9: Faça um programa que peça ao usúario um número e imprima a soma dos números de 1 até esse número.
        public int ExercicioNove(int num )
        {

            int soma = 0; 

            for(int i = 0; i <= num; i++)
            {
                soma += i;

            }//fim do for 
            return soma;
        }//fim do metodo 

        //Exercicio 10: Faça um programa que imprima os números primos de 1 a 20. 
        public string ExercicioDez()
        {

            string primos = "2 3 5";
            for(int i = 0; i <= 20; i++)
            {

               if( i % 2 != 0 && i % 3 != 0 && i % 5 != 0 )
                {

                    primos += " " + i; 
                }//fim do if 
            }//fim do for
            return primos; 
        }//fim do metodo 

        //Exercicio 11: Faça um programa que peça ao usuario um número e verifique se é primo. 
        public string ExercicioOnze(int num)
        {

           if (num % 2 != 0 && num % 3 != 0 && num % 5 != 0)
            {

                return "Primo!";
            }else if (num == 2 || num == 3 || num == 5)
            {
                return "Primo!";
            }
            else
            {
                return "Não primo!"; 
            }

        }//fim do metodo 
    
    

        //Exercicio 12: Faça um programa que calcule o fatoral de um número. 
        public int ExercicioDoze(int num)
        {
            int resultado = 1; 
            while(num !=0)
            {
                resultado = (resultado * num); 
                num = num - 1;
            }//fim do while 
            return resultado;
        }//fim do metodo 

        //Exercicio 13: Faça um programa que imprima a sequência de Fibonacci até o decimo termo. 
        public 

    }//fim da classe
}//fim do projeto 
