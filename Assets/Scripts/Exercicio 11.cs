using UnityEngine;
using static TMPro.SpriteAssetUtilities.TexturePacker_JsonArray;

public class Exercicio11 : MonoBehaviour
{
    //    (Di�logos) Implemente um sistema de di�logos onde o jogador
    //  pode interagir com um NPC(personagem n�o jog�vel), e o NPC
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
                print("Cada n�vel � mais desafiador, mas voc� n�o est� sozinho!");
                print("Com cada desafio, me torno mais determinado. Vamos enfrentar o que vier!");
                break;
            case 02:
                print("O inimigo est� mais forte, mas voc� tamb�m est� mais preparado!");
                print("Quanto mais forte o inimigo, mais forte eu me torno. A vit�ria ser� minha!");
                break;
            case 03:
                print("Cada vit�ria � uma li��o para o pr�ximo desafio!");
                print("Cada vit�ria � uma li��o para o pr�ximo desafio!");
                break;
            case 04:
                print("A jornada est� apenas come�ando, o melhor ainda est� por vir!");
                print("Estou preparado para o que est� por vir. Vamos encarar essa jornada de frente!");
                break;
            case 05:
                print("O mundo do jogo est� repleto de mist�rios. Est� pronto para desbrav�-los?");
                print("Mist�rios e aventuras me aguardam! Mal posso esperar para descobrir o que est� � espera.");
                break;
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
