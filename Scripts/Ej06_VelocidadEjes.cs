using UnityEngine;

// Ejercicio 6: muestra velocidad * eje vertical y velocidad * eje horizontal
// al pulsar las flechas. El mensaje empieza por el nombre de la flecha.
public class Ej06_VelocidadEjes : MonoBehaviour
{
    public float velocidad = 2.0f;

    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow)) Mostrar("Flecha arriba");
        if (Input.GetKey(KeyCode.DownArrow)) Mostrar("Flecha abajo");
        if (Input.GetKey(KeyCode.LeftArrow)) Mostrar("Flecha izquierda");
        if (Input.GetKey(KeyCode.RightArrow)) Mostrar("Flecha derecha");
    }

    void Mostrar(string flecha)
    {
        float vertical = velocidad * Input.GetAxis("Vertical");
        float horizontal = velocidad * Input.GetAxis("Horizontal");
        Debug.Log(flecha + ": velocidad * vertical = " + vertical +
                  " | velocidad * horizontal = " + horizontal);
    }
}
