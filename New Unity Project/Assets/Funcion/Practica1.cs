using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Practica1 : MonoBehaviour
{
    void Start()
    {

        Debug.Log("\nMateria: Diseño de interacciones    Practica: 1    Alumna: Capistran Martinez Areli    Matricula: 1262509\n");
        int tamano = 5;
        int[] arreglo = { 8, 1, 2, 2, 3 };
        int[] final = { 0, 0, 0, 0, 0 };

        final = NumerosMenores(arreglo, final, tamano);
        Imprimir(arreglo, final, tamano);

    }

    public int[] NumerosMenores(int[] arreglo, int[] final, int tamano)
    {
        int cont;

        for (int i = 0; i < tamano; i++)
        {
            cont = 0;
            for (int j = 0; j < tamano; j++)
            {
                if (arreglo[i] > arreglo[j])
                {
                    final[i] = cont + 1;
                    cont++;
                }
            }
        }
        return final;
    }


    public void Imprimir(int[] arreglo, int[] final, int tamano)    
    {
        Debug.Log("\nArreglo inicial: ");
        for (int i = 0; i < tamano; i++)
        {
            Debug.Log("[" + arreglo[i] + "] ");
        }

        Debug.Log("\nArreglo final: ");
        for (int j = 0; j < tamano; j++)
        {
            Debug.Log("[" + final[j] + "] ");
        }
    }
}
