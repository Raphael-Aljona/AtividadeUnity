using System;
using Unity.Collections;
using UnityEditor;
using UnityEngine;
using UnityEngine.Networking;
using static Unity.Burst.Intrinsics.X86;

public class Exercicio08 : MonoBehaviour
{
    //    (Contador de horas e dias) Crie um script que em que uma
    //  vari�vel inteira hora seja incrementada de uma unidade a cada 10
    //  segundos
    //
    //  e volte a ser 0 quando alcan�ar o valor 24. Quando
    //  completar um ciclo, incremente uma vari�vel dias e escreva o
    //  n�mero de dias que se passaram no console. (Coloque o c�digo
    //  dentro da fun��o-evento Update).

    [SerializeField] int hora;
    [SerializeField] int dia;
    float segundos;

    void Start()
    {
        
    }

  
    void Update()
    {
        segundos += Time.deltaTime;

        if (segundos >= 10)
        {
            hora ++;
            segundos = 0;
                if (hora == 24)
                {
                dia++;
                hora = 0;
                }
        }

        if (dia >= 1)
        {
            print(dia);

        }


        // Os avan�os de dia e hora est�o no inspector
    }
}
