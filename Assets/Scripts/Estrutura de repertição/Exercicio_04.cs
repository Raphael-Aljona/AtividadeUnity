using UnityEngine;

public class Exercicio_04 : MonoBehaviour
{

    //  (Pontua��o em combos) Cada combo realizado aumenta em 10
    //  pontos.Exiba a pontua��o total ap�s 7 combos.

    int combo = 1;
    int pontuacao;

    void Start()
    {
        for (combo = 1; combo <= 7; combo++)
        {
            pontuacao += 10;
            if (combo == 7)
            {
                print(pontuacao);

            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
