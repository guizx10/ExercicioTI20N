using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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

                resultado += "\n" + i+1;

            }

        }//fim do Método 

    }//fim da classe
}//fim do projeto 
