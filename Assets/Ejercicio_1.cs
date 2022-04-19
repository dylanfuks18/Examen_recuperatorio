using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio_1 : MonoBehaviour
{
    public int cantidadHel;
    public string gusto;
    // Start is called before the first frame update
    //    Esta heladería ofrece 3 gustos: chocolate, frutilla y dulce de leche y toma pedidos mediante códigos.El cliente debe pedir los gustos 
    //ingresando CHO, FRU y DDL.Además debe ingresar una cantidad de helado en gramos (250 para un cuarto, 500 para medio k, etc). 
    //Esta semana tiene una promoción con frutilla, por lo que el precio se reduce un %10 solo en ese gusto.


    //.Mostrar un mensaje de error y ningún otro mensaje ni realizar ningún cálculo si no se ingresa un código válido o si las cantidades de helado son menores a 250 o mayores que 3000. 

    //. Sabiendo que el kilo de helado sale $500, devolver el costo del pedido si los ingresos son válidos. Recuerdo contemplar la promoción.





    void Start()
    {
        if (cantidadHel < 250 || cantidadHel > 3000)
        {
            Debug.Log("Error, cantidad ingresada no valida");
        }
        if (gusto == "DDL" || gusto == "CHO" || gusto == "FRU")
        {
            if (cantidadHel == 250)
            {
                if (gusto == "FRU")
                {
                    Debug.Log("El precio de 250g, con la promoción es de $" + 500 / 4 * 0.90);
                }
                else
                {
                    Debug.Log("El precio de 250g es de $" + 500 / 4);
                }
            }
            else if (cantidadHel == 500)
            {
                if (gusto == "FRU")
                {
                    Debug.Log("El precio de 500g, con la promoción es de $" + 500 / 2 * 0.90);
                }
                else
                {
                    Debug.Log("El precio de 500g es de $" + 500 / 2);
                }
            }
            if (cantidadHel == 1000)
            {
                if (gusto == "FRU")
                {
                    Debug.Log("El precio de 1kg, con la promoción es de $" + 500 * 0.90);
                }
                else
                {
                    Debug.Log("El precio de 1kg es de $500");
                }
            }
        }
        else
        {
            Debug.Log("Error, gusto ingresado no valido");
        }

    }





        // Update is called once per frame
        void Update() { }

    }        
  