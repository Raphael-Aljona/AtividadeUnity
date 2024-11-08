using UnityEngine;
using static TMPro.SpriteAssetUtilities.TexturePacker_JsonArray;

public class Exercicio11 : MonoBehaviour
{
    //    (Di�logos) Implemente um sistema de di�logos onde o jogador
    //  pode interagir com um NPC(personagem n�o jog�vel), e o NPC
    //  responde com diferentes frases dependendo do estado do jogo.
    //  Use switch case para definir as respostas baseadas no estado do
    //  jogador.

    
    
    [SerializeField]int resposta;

    void Start()
    {

        switch (resposta)
        {

            case 01:
                print("Cada n�vel � mais desafiador, mas voc� n�o est� sozinho!");
                break;
            case 02:
                print("O inimigo est� mais forte, mas voc� tamb�m est� mais preparado!");
                break;
            case 03:
                print("Cada vit�ria � uma li��o para o pr�ximo desafio!");
                break;
            case 04:
                print("A jornada est� apenas come�ando, o melhor ainda est� por vir!");
                break;
            case 05:
                print("O mundo do jogo est� repleto de mist�rios. Est� pronto para desbrav�-los?");
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
