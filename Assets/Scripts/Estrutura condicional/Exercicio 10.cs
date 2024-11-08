using UnityEngine;
using static UnityEditor.Progress;

public class Exercicio10 : MonoBehaviour
{
    //    (Itens do invent�rio) Crie um script onde o jogador pode coletar
    //  diferentes tipos de itens(como moedas, po��es, ou power-ups)
    //  que t�m efeitos diferentes dependendo do tipo coletado.Use um
    //  switch case para determinar o efeito de cada tipo de item.

    [SerializeReference] string tipoItem;
    [SerializeReference] int moeda;
    [SerializeReference] bool escudo = false;
    [SerializeReference] bool pocao = false;

    void Start()
    {
        switch (tipoItem)
        {
            case "Moeda":
                moeda++;
                print("Moeda coletada, voc� tem" + moeda + "moedas");
                break;
            case "Escudo":
                escudo = true;
                print("Escudo Ativo!");
                break;
            case "Cura":
                pocao = true;
                print("Voc� usou uma po��o de vida");
                break;

        }
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
