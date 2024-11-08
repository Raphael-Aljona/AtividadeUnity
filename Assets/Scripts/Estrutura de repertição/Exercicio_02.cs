using UnityEngine;

public class Exercicio_02 : MonoBehaviour
{
    // Um personagem ataca cinco vezes, e o
    // dano do ataque aumenta em 2 a cada vez.Exiba o dano a cada
    // ataque.

    int dano = 1;
    int combo = 1;

    void Start()
    {


        for (combo = 1; combo <= 5; combo++)
        {
            dano += 2;
            print(dano);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
