using System;
using System.Linq;
using UnityEngine;

// Escreva um programa que conta o n�mero de consoantes em uma string.

public class Desafio1 : MonoBehaviour
{

    [SerializeField] char[] vogais = { 'a', 'e', 'i', 'o', 'u' };
    void Start()
    {
        string frase = "abcdefg";
        int consoantes = 0;
        foreach (char c in frase.ToLower())
        {
            if (vogais.Contains(c) || !Char.IsLetter(c)) { continue; }
            consoantes++;
        }
        print($"A frase \"{frase}\" tem {consoantes} consoantes.");

    }

    //var.Contains() -- Verifica se um dos caracteres digitados � algo incluido na variavel var, no caso, "vogais";
    //Char.IsLetter() -- Verifica se � uma letra, como no caso est� com ! o valor ser� invertido ou seja, ir� verificar se n�o � uma letra;

    void Update()
    {

    }
}