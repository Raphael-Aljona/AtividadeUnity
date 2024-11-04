using UnityEngine;

public class Exercicio03 : MonoBehaviour
{
    int vidaPersonagem = 100;
    int vidaRevive;
    bool powerUp = true;


    void Start()
    {
        if (powerUp == true)
        {
            print("Você coletou um revive power-up");
            int vidaRevive = 50 % vidaPersonagem;
        }
        else
        {
            print("Game Over");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
