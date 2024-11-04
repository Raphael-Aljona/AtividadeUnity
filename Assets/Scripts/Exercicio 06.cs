using UnityEngine;

public class Exercicio06 : MonoBehaviour
{
    //(Escolha de personagem) O jogador pode escolher entre o personagem Guerreiro ou Mago.Exiba "Guerreiro escolhido" se o
    //jogador selecionar Guerreiro e "Mago escolhido" se selecionar  Mago.

    [SerializeField] int escolha;
    void Start()
    {
        switch (escolha)
        {
            case 1:
                print ("Guerreiro escolhido");
                break;

            case 2:
                print("Mago escolhido");
                break;

            default:
                print("Valor invalido");
                break;
        }   

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
