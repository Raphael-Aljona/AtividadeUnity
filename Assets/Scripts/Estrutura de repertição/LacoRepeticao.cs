using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LacoRepeticao : MonoBehaviour

    // For -> � utilizada quando voc� sabe a quantidade de repeti��es

    // DoWhile ou While -> � utilizado quando n�o se sabe a quantidade de repeti��es

    // ForEach -> Jsado em listas ou array para executar uma opera��o para cada item da lista

    // Array -> Uma lista
{
    // Listas de n�meros
    List<int> nums = new List<int>();

    // nums.add(1);
    // nums.add(2);
    // nums.IndexOf(1); Aparece o index do valor indicado
    // nums.Sort(); Ordena a lista crescetemente
    // nums.Reverse() Ordena a lista descrescentemente


    int x = 0;
    int y = 10;



    void Start()
    {
        //For (inicializaor, condi��o, incremento/decremento
        //for (int i = 0; i < 10; i++)
        //{
        //    //if (i == 0)
        //    //    print(i);
        //    //if (i == 5)
        //    //    break;     //para o codigo
        //    //if (i == 6)
        //    //    continue;  //pula o elemento, pois ao chegar a 6
        //}


        //While (Quando)
        //while (x <= 10)
        //{
        //    print(x);
        //    x++;
        //}

        //Do while
        //do
        //{
        //    print(y);
        //    y--;
        //} while (y >= 0);


        //Array de numeros
        //int[] num = { 10, 20, 30, 40, 50, 60, 70, 80 };
        //print(num[3]);
        //num[0]++; //soma ao n�mero do int (ex: num 0 = 10; num++; num 0 = 11;)
        //print(num[0]);

        //Array de nomes
        //string[] nomes;
        //nomes = new string[5];
        //nomes[0] = "Tadola";
        //print(nomes[0]);





    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
