using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeladeriaLosTresGustos : MonoBehaviour
{
    public string codigoGusto;
    public int cantidadHelado;
    float precioGramo = 1250/1000f;
    float precioPedido;
    
    // Start is called before the first frame update
    void Start()
    {
        if ((cantidadHelado < 250) || (cantidadHelado > 3000)) { 
            Debug.Log("Cantidad de helado no válida, se debe ingresar de 250g hasta 3000g.");
            return;

        }


        if (codigoGusto == "CHO")
        {
            precioPedido = cantidadHelado * precioGramo;
            Debug.Log("El precio de tu pedido es $" + precioPedido);

        } else if (codigoGusto == "FRU")
        {
            precioPedido = (cantidadHelado * precioGramo) * 0.9f;
            Debug.Log("El precio de tu pedido es $" + precioPedido);

        } else if (codigoGusto == "DDL")
        {
            precioPedido = cantidadHelado * precioGramo;
            Debug.Log("El precio de tu pedido es $" + precioPedido);

        } else {
            Debug.Log("Código ingresado no válido.");

        }
    }
    // Update is called once per frame
   void Update()
   {

   }
}
