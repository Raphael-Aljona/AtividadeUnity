using NUnit.Framework;
using System;
using UnityEngine;

public class Exercicio_06 : MonoBehaviour
{
    //  6 (Fizz Buzz) Para cada n�mero entre 0 e 10000, escreva apenas
    //  �fizz� no console quando for divis�vel por 3, �buzz� quando for
    //  divis�vel por 5 e �fizz buzz� quando for divis�vel pelos dois.Se o
    //  n�mero n�o for divis�vel por nenhum deles, escreva-o no console.

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
                print("Esse n�mero n�o � divisivel tanto por 3 quanto por 5 ");
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
