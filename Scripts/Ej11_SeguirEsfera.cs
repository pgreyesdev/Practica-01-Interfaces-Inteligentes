using UnityEngine;

// Ejercicio 11: el cubo avanza hacia la esfera a velocidad constante,
// sin cambiar su altura. La dirección se normaliza para que el avance
// no dependa de la distancia entre ambos objetos.
public class Ej11_SeguirEsfera : MonoBehaviour
{
    public Transform esfera;
    public float speed = 3.0f;
    public float distanciaParada = 0.1f;

    void Start()
    {
        if (esfera == null)
            esfera = GameObject.FindWithTag("blue_sphere").transform;
    }

    void Update()
    {
        Vector3 direccion = esfera.position - transform.position;
        direccion.y = 0.0f; // el cubo no modifica su altura

        if (direccion.magnitude > distanciaParada)
        {
            transform.Translate(direccion.normalized * speed * Time.deltaTime, Space.World);
        }
    }
}
