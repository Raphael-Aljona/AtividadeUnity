using UnityEngine;

public class Exercicio04 : MonoBehaviour
{
    //    (Verificar item de inventário) Um jogador possui itens limitados
    //no inventário.Verifique se o jogador possui uma "Poção de Vida".
    //Se possuir, exiba "Usando Poção de Vida"; caso contrário, "Poção
    //indisponível".

    string player;
    [SerializeField] bool pocaoVida;

    void Start()
    {
        print(player = pocaoVida ? "Usando Poção de Vida" : "Poção indisponivel");
    }


    void Update()
    {
        
    }
}
