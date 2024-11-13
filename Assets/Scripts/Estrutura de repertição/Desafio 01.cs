using System;
using System.Linq;
using UnityEngine;

// Escreva um programa que conta o número de consoantes em uma string.

public class Desafio1 : MonoBehaviour
{

    //maneira 1
    [SerializeField] string frase = "Olá, boa tarde";
    [SerializeField] int consoantes;



    //maneira 2
    //[SerializeField] char[] vogais = { 'a', 'e', 'i', 'o', 'u' };
    void Start()
    {

        //maneira 1
        for (int i = 0; i < frase.Length; i++)
        {
            char letra = frase[i];
            if ("bcdfghjklmnpqrstvwxyz".Contains(char.ToLower(letra)))
            {
                consoantes++;
            }
        }
            print("Essa é sua frase: " + frase + " e esse é o número de consoantes " + consoantes);

        
        //maneira 2

        //string frase = "abcdefg";
        //int consoantes = 0;
        //foreach (char c in frase.ToLower())
        //{
        //    if (vogais.Contains(c) || !Char.IsLetter(c)) { continue; }
        //    consoantes++;
        //}
        //print($"A frase \"{frase}\" tem {consoantes} consoantes.");

    }

    //var.Contains() -- Verifica se um dos caracteres digitados é algo incluido na variavel var, no caso, "vogais";
    //Char.IsLetter() -- Verifica se é uma letra, como no caso está com ! o valor será invertido ou seja, irá verificar se não é uma letra;

    void Update()
    {

    }
}