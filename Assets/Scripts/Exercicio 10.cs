using UnityEngine;
using static UnityEditor.Progress;

public class Exercicio10 : MonoBehaviour
{
    //    (Itens do invent�rio) Crie um script onde o jogador pode coletar
    //  diferentes tipos de itens(como moedas, po��es, ou power-ups)
    //  que t�m efeitos diferentes dependendo do tipo coletado.Use um
    //  switch case para determinar o efeito de cada tipo de item.

    [SerializeField]int inventario;
    [SerializeField]bool moedas;
    [SerializeField]bool  powerUp;
    [SerializeField]bool pocoes;

    void Start()
    {
        switch (inventario)
        {
            case 01:
                if (moedas == true)
                {
                print("Voc� ficou muito rico $$");
                }
                break;

            case 02:
                if (powerUp == true)
                {
                    print("Sua for�a aumentou em 10x");
                }
                break;

            case 03:
                if (moedas == true)
                {
                    print("Voc� ganhou +1 vida!");
                }
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
