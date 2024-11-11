using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Exercicio_08 : MonoBehaviour
{
    string nome = "raphael";
    string nome2;
    void Start()
    {
        //for (int num = nome.Length; num > 0; num--)
        //{
        //    nome2 += ;
        //}
        //print(nome2);
        print(nome.Length);

        for (int i = nome.Length ; i >=0 ; i--)
        {
            nome2 += nome[i - 1];
            print(nome2);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
