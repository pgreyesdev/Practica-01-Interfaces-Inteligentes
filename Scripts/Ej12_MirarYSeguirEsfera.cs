using UnityEngine;

// Ejercicio 12: el cubo gira para que su eje Z positivo apunte a la esfera
// y avanza hacia ella.
public class Ej12_MirarYSeguirEsfera : MonoBehaviour
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
        // Objetivo a la altura del cubo para que no se incline ni cambie de altura.
        Vector3 objetivo = new Vector3(esfera.position.x, transform.position.y, esfera.position.z);
        transform.LookAt(objetivo);

        if (Vector3.Distance(transform.position, objetivo) > distanciaParada)
        {
            transform.Translate(transform.forward * speed * Time.deltaTime, Space.World);
        }

        Debug.DrawRay(transform.position, transform.forward * 2.0f, Color.red);
    }
}
