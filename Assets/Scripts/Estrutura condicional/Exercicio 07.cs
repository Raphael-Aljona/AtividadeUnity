using UnityEngine;
using static Unity.Burst.Intrinsics.X86;
using static UnityEditor.PlayerSettings;
using static UnityEngine.EventSystems.EventTrigger;

public class Exercicio07 : MonoBehaviour
{

    //    (Dado com N faces) Para fazer um jogo de RPG, vamos precisar
    //  calcular probabilidades e simular a rolagem de dados.Crie um
    //  script em que o usu�rio defina o n�mero de faces de um dado
    //  (int) e calcule a rolagem de um dado com esse n�mero de faces.
    //  Use a fun��o abaixo para o c�lculo: Random.Range (valor_min,
    //  valor_max); (Coloque o c�digo dentro da fun��o-evento Start).

    [SerializeField] int faces;
    int resultado;



    void Start()
    {
       
            resultado = Random.Range(1, faces+1);
            print(resultado);
     

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}