using UnityEngine;

public class Exercicio04 : MonoBehaviour
{
    //    (Verificar item de invent�rio) Um jogador possui itens limitados
    //no invent�rio.Verifique se o jogador possui uma "Po��o de Vida".
    //Se possuir, exiba "Usando Po��o de Vida"; caso contr�rio, "Po��o
    //indispon�vel".

    string player;
    [SerializeField] bool pocaoVida;

    void Start()
    {
        print(player = pocaoVida ? "Usando Po��o de Vida" : "Po��o indisponivel");
    }


    void Update()
    {
        
    }
}
