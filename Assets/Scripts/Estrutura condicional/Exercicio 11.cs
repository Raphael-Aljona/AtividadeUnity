using UnityEngine;
using static TMPro.SpriteAssetUtilities.TexturePacker_JsonArray;

public class Exercicio11 : MonoBehaviour
{
    //    (Diálogos) Implemente um sistema de diálogos onde o jogador
    //  pode interagir com um NPC(personagem não jogável), e o NPC
    //  responde com diferentes frases dependendo do estado do jogo.
    //  Use switch case para definir as respostas baseadas no estado do
    //  jogador.

    
    
    [SerializeField]int resposta;

    void Start()
    {

        switch (resposta)
        {

            case 01:
                print("Cada nível é mais desafiador, mas você não está sozinho!");
                break;
            case 02:
                print("O inimigo está mais forte, mas você também está mais preparado!");
                break;
            case 03:
                print("Cada vitória é uma lição para o próximo desafio!");
                break;
            case 04:
                print("A jornada está apenas começando, o melhor ainda está por vir!");
                break;
            case 05:
                print("O mundo do jogo está repleto de mistérios. Está pronto para desbravá-los?");
                break;
            default:
                print("Nada a dizer sobre isso");
                break;
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
