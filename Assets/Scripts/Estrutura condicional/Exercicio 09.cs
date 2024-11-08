using System;
using Unity.VisualScripting;
using UnityEngine;

public class Exercicio09 : MonoBehaviour
{
    //    9. (Placar final) Crie um script que lê o placar de uma partida entre
    //  time A e time B.Depois, escreva no console qual dos três
    //  resultados possíveis aconteceu: vitória do time A, vitória do time B
    //  ou empate.Se o empate teve mais de 3 pontos para cada lado,
    //  escreva que foi “um empate emocionante”.

    [SerializeField]int timeA;
    [SerializeField]int timeB;

    void Start()
    {
        if (timeA > timeB)
        {
            print ("vitória do time A");
        } else if (timeB > timeA)
        {
            print("vitória do time B");
        } else if(timeA > 3 && timeA == timeB)
        {
            print("um empate emocionante");
        } else if(timeA == timeB) {
            print("empate");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

