using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dadospoker : MonoBehaviour
{
    // Start is called before the first frame update

    char[] dadosValor = { '7', '8', 'J', 'Q', 'K', 'A' };
    char[] dados = new char[6];
    public int tiradas = 0;

    public bool[] dadosSeleccion = new bool[6];
    string tiradaDados = null;

    public bool tiraDados = false;
    public bool reset;


    void Start()
    {
        tiradas = 0;
        dadosSeleccion = new bool[]{true, true, true, true, true, true};
    }

    // Update is called once per frame
    void Update()
    {
        if(reset)
        {
            tiradas = 0;
            dadosSeleccion = new bool[] { true, true, true, true, true, true };
            reset = false;
            print("Haga su tirada:");
        }
        if (tiraDados)
        {
           
            tiradas++;
            tiradaDados = null;
            for (int i = 0; i < dadosSeleccion.Length; i++)
            {
                if (dadosSeleccion[i]==true)
                {
                    dados[i] = dadosValor[Random.Range(0, 5)];
                    
                }

                if (i < dadosSeleccion.Length - 1)
                {
                    tiradaDados += dados[i] + ",";
                }
                else
                {
                    tiradaDados += dados[i];
                }
                
            }
            print("El valor del dado es:" + tiradas + ") " + tiradaDados);
            tiraDados = false;
        }
    }
}
