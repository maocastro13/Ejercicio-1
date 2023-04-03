using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjecicioPrueba1 : MonoBehaviour
{
    int[] ejercicio1 = {10, 20, 30, 40, 50};

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            for (int i = ejercicio1.Length - 2; i < ejercicio1.Length; i++)
            {
                Debug.Log("la respuesta es: " + ejercicio1[i]);
            }
        }
    }
}