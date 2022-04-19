using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GustosDeHelado : MonoBehaviour
{
    public string Gusto;
    public int CantidadG;

    int total;
    // Start is called before the first frame update
    void Start()
    {
        if (CantidadG < 250 || CantidadG > 3000)
        {
            Debug.Log("La cantidad de gramos mínima es de 250");
        }

        else
        {
            total = (CantidadG / 1000) * 500;

            switch (Gusto)
            {
                case "DDL":
                    Debug.Log("Usted pidió " + CantidadG + " gramos de dulce de leche");
                    Debug.Log("El precio total es de $"+total);
                    break;
                case "CHO":
                    Debug.Log("Usted pidió " + CantidadG + " gramos de chocolate");
                    Debug.Log("El precio total es de $" + total);
                    break;
                case "FRU":
                    CantidadG = (CantidadG / 100) * 90 ;
                    Debug.Log("Usted pidió " + CantidadG + " gramos de frutilla");
                    Debug.Log("El precio total es de $" + total);
                    break;
                default:
                    Debug.Log("Usted no pidió ningún gusto");
                    break;

            }
        }
       
         
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
