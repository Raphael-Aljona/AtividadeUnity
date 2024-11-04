using UnityEngine;

public class Exercicio02 : MonoBehaviour
{
    string jogador;
    [SerializeField] bool powerUp = true;

    void Start()
    {
        jogador = powerUp == true ? "Power Up coletado" : "Nenhum Power Up encontrado";
        print(jogador);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
