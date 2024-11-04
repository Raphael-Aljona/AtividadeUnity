using UnityEngine;

public class Exercicio02 : MonoBehaviour
{
    string jogador;
    [SerializeField] bool powerUp = true; // n precisa colocar true, pois por padrão ja vem true

    void Start()
    {
        jogador = powerUp == true ? "Power Up coletado" : "Nenhum Power Up encontrado"; //é possivel printar nesta mesma linha e tirar também o true dela.
        print(jogador);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
