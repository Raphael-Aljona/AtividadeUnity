using System;
using UnityEngine;

public class Desafio02 : MonoBehaviour
{
    /*Fa�a um algoritmo que receba o dia,
    * o m�s e o ano em que uma pessoa nasceu, imprima na tela quantos anos, 
    * meses e dias essa pessoa j� viveu. Leve em considera��o o ano com 365 dias e o m�s com 30 dias.
    */



    [SerializeField] int ano;
    [SerializeField] int mes;
    [SerializeField] int dia;
    [SerializeField] int anoAtual = DateTime.Now.Year;
    [SerializeField] int mesAtual = DateTime.Now.Month;
    [SerializeField] int diaAtual = DateTime.Now.Day;

    void Start()
    {
        int quantosAnos = anoAtual - ano;

        if (mes > mesAtual || (dia > diaAtual && mes == mesAtual))
        {
            quantosAnos--;
        }

        int quantosMeses = (mesAtual - mes + 12) % 12; //Serve para verificar o resto e utiliza-lo como resultado exemplo 12/11 = resto 1, por tanto dar� 1 m�s
        int quantosDias = (diaAtual - dia + 30) % 30;


        print(quantosAnos + "Anos");
        print(quantosMeses + "Meses");
        print(quantosDias + "Dias");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
