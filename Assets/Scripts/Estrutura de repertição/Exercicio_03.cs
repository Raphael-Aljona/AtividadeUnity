using UnityEngine;

public class Exercicio_03 : MonoBehaviour
{
    //(C�lculo de moedas coletadas) O jogador coleta 3 moedas a
    //cada fase.Ap�s 10 fases, exiba o total de moedas coletadas.

    int moedas = 0;
    int fases = 1;

    void Start()
    {
        for (fases = 1; fases <= 10; fases++)
        {
            moedas += 3;
            if (moedas == 30)
            {
                print("voc� coletou " + moedas + "moedas");
            }
            
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
