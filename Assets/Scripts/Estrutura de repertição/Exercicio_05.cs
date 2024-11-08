using UnityEngine;

public class Exercicio_05 : MonoBehaviour
{
    //  5. (Aumento de nível de dificuldade) A cada fase completada, a
    //  dificuldade aumenta em 5 pontos.Exiba a dificuldade após cada
    //  fase, em um total de 6 fases.

    int fase = 1;
    int dificuldade;


    void Start()
    {
        for (fase = 1; fase <=6; fase++)
        {
            dificuldade += 5;
            print(dificuldade);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
