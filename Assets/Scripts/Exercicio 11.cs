using UnityEngine;
using static TMPro.SpriteAssetUtilities.TexturePacker_JsonArray;

public class Exercicio11 : MonoBehaviour
{
    //    (Diálogos) Implemente um sistema de diálogos onde o jogador
    //  pode interagir com um NPC(personagem não jogável), e o NPC
    //  responde com diferentes frases dependendo do estado do jogo.
    //  Use switch case para definir as respostas baseadas no estado do
    //  jogador.

    
    [SerializeField]int interacao;
    int resposta;

    void Start()
    {
        switch (interacao)
        {
            
        }

        switch (resposta)
        {

            case 01:
                print("Cada nível é mais desafiador, mas você não está sozinho!");
                print("Com cada desafio, me torno mais determinado. Vamos enfrentar o que vier!");
                break;
            case 02:
                print("O inimigo está mais forte, mas você também está mais preparado!");
                print("Quanto mais forte o inimigo, mais forte eu me torno. A vitória será minha!");
                break;
            case 03:
                print("Cada vitória é uma lição para o próximo desafio!");
                print("Cada vitória é uma lição para o próximo desafio!");
                break;
            case 04:
                print("A jornada está apenas começando, o melhor ainda está por vir!");
                print("Estou preparado para o que está por vir. Vamos encarar essa jornada de frente!");
                break;
            case 05:
                print("O mundo do jogo está repleto de mistérios. Está pronto para desbravá-los?");
                print("Mistérios e aventuras me aguardam! Mal posso esperar para descobrir o que está à espera.");
                break;
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
