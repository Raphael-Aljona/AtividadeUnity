using UnityEngine;

public class Exercicio03 : MonoBehaviour
{
    [SerializeField] bool personagem;
    bool powerUp;
    double vidaPersonagem = 100;

    void Start()
    {
       if (personagem == false && powerUp == true)
        {
            vidaPersonagem = vidaPersonagem * 0.5;
            print("Ainda não, vida atual " + vidaPersonagem);
        }else
        {
            print("Game Over!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
