using UnityEngine;

// Ejercicio 13: el eje "Horizontal" gira el objeto sobre su eje Y
// y este avanza siempre en su dirección hacia delante (transform.forward).
public class Ej13_GiroYAvance : MonoBehaviour
{
    public float speed = 3.0f;
    public float velocidadGiro = 90.0f; // grados por segundo

    void Update()
    {
        float giro = Input.GetAxis("Horizontal");
        transform.Rotate(0.0f, giro * velocidadGiro * Time.deltaTime, 0.0f);

        transform.Translate(transform.forward * speed * Time.deltaTime, Space.World);

        Debug.DrawRay(transform.position, transform.forward * 2.0f, Color.green);
    }
}
