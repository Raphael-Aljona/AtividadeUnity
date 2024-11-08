using UnityEngine;

public class Exercicio01 : MonoBehaviour
{
    [SerializeField] int vidaPersonagem = 100;
    string verificacaoVida;

    void Start()
    {
        verificacaoVida = vidaPersonagem > 0 ? "Personagem Vivo" : "Game Over";
        print(verificacaoVida);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
