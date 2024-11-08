using UnityEngine;

public class Exercicio06 : MonoBehaviour
{
    //(Escolha de personagem) O jogador pode escolher entre o personagem Guerreiro ou Mago.Exiba "Guerreiro escolhido" se o
    //jogador selecionar Guerreiro e "Mago escolhido" se selecionar  Mago.

    [SerializeField] bool Guerreiro = false;
    
    void Start()
    {
        print(Guerreiro ? "Guerreiro escolhido" : "Mago escolhido");
    }

    

    // Update is called once per frame
    void Update()
    {
        
    }
}
