using UnityEngine;

public class Exercicio02 : MonoBehaviour
{
    string jogador;
    [SerializeField] bool powerUp = true; // n precisa colocar true, pois por padr�o ja vem true

    void Start()
    {
        jogador = powerUp == true ? "Power Up coletado" : "Nenhum Power Up encontrado"; //� possivel printar nesta mesma linha e tirar tamb�m o true dela.
        print(jogador);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
