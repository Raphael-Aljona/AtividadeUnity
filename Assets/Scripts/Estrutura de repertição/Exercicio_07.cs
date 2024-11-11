using System;
using System.Collections.Generic;
using System.Drawing;
using Unity.VisualScripting;
using UnityEngine;
using static Unity.Burst.Intrinsics.X86;

public class Exercicio_07 : MonoBehaviour
{
    //(Maior número em uma lista) Dada uma lista de números,
    //encontre o maior valor.
    List<int> lista = new List<int>();
    void Start()
    {
        lista.Add(382);
        lista.Add(157);
        lista.Add(294);
        lista.Add(41);
        lista.Add(469);
        lista.Add(258);
        lista.Add(34);
        lista.Add(511);
        lista.Add(202);
        lista.Add(321);
        lista.Add(136);
        lista.Add(478);
        lista.Add(75);
        lista.Add(314);
        lista.Add(120);
        lista.Add(88);
        lista.Add(263);
        lista.Add(407);
        lista.Add(59);
        lista.Add(196);
        lista.Sort();
        print(lista[20] + ". Esse é o maior valor!");
    }

        // Update is called once per frame
        void Update()
    {
        
    }
}
