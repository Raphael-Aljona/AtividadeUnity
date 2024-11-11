using NUnit.Framework;
using System;
using UnityEngine;

public class Exercicio_06 : MonoBehaviour
{
    //  6 (Fizz Buzz) Para cada número entre 0 e 10000, escreva apenas
    //  “fizz” no console quando for divisível por 3, “buzz” quando for
    //  divisível por 5 e “fizz buzz” quando for divisível pelos dois.Se o
    //  número não for divisível por nenhum deles, escreva-o no console.

    int num = 1;


    void Start()
    {
        for(num = 1; num < 10000; num++)
        {

            if (num % 5 == 0 && num % 3 == 0)
            {
                print(num + " fizz buzz");
            } else if (num % 5 == 0)
            {
                print(num + " buzz");
            } else if(num % 3 == 0)
            {
                print(num + " fizz");
            } else
            {
                print("Esse número não é divisivel tanto por 3 quanto por 5 ");
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
