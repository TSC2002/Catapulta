using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotar : MonoBehaviour
{
    public float Sensibilidad = 10.0f; //Velocidad de giro

    //Datos de entrada del mouse
    Vector2 MouseDelta = Vector2.zero;
    Vector2 Cantidad = Vector2.zero;
   
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space)) { Cantidad = Vector2.zero; } //Resetear la rotacion

        //Desplazar con el mouse la rotacion
        MouseDelta.Set(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));

        //Amplificar o reducir el movimiento segun la sensibilidad
        Cantidad += MouseDelta * Sensibilidad;
        Cantidad.y = Mathf.Clamp(Cantidad.y, -90, 90); //Restringir la rotacion

        //Mezclar las 2 rotaciones
        transform.rotation = Quaternion.AngleAxis(Cantidad.x, Vector3.up) * Quaternion.AngleAxis(Cantidad.y, Vector3.right);
    }
}
