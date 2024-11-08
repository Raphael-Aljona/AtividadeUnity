using UnityEngine;

public class Geral : MonoBehaviour
{
    //public string variavelPublica;
    //[SerializeField] private int variavelPrivada = 1;

    //int vidaJogador = 10;
    //float velocidadeCarro = 125.2f;
    //string nomeJogador = "Apollo";
    //char apelido = 'A';
    //bool vivo = true;

    //int variavelGlobal;

    /*
     * 
     * Operadores Relacionais
     * == igual
     * != diferente
     * > Maior que
     * < Menor que
     * >= Maior ou igual a que
     * <= Menor ou igual a que
     */

    [SerializeField] int vidaHeroi = 100;
    [SerializeField] int vidaVilao = 300;
    string resultado;

    /* Operadores Logicos
     * 
     */

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Debug.Log("Hello World!");

        //int variavelLocal = 1;
        //print(variavelLocal);
        //print(variavelGlobal);

        //print(vivo);
        //print(vidaJogador);
        //print(variavelPublica);

        //print(vidaVilao == vidaHeroi);//false
        //print(vidaHeroi == vidaVilao);//true
        //print(vidaVilao != vidaHeroi);//true

        //resultado = vidaHeroi < vidaVilao ? "Vida Heroi Menor" : "Vida Heroi Maior";

        //print(resultado);


        //Estrutura condicional
        //if (vidaHeroi < vidaVilao)
        //{
        //    resultado = "Vida Heroi Maior";
        //    print("resultado");
        //}
        //else
        //{
        //    resultado = "Vida Heroi Menor";
        //    print("resultado");
        //}
    }

    // Update is called once per frame
    void Update()
    {
        //print(variavelGlobal);
    }
}
