using UnityEngine;

// Ejercicio 5: al pulsar la barra espaciadora el objeto se coloca en
// su posición original + desplazamiento (deltax, deltay, deltaz).
public class Ej05_Desplazamiento : MonoBehaviour
{
    public Vector3 desplazamiento = new Vector3(0.0f, 2.0f, 0.0f);

    private Vector3 posicionOriginal;

    void Start()
    {
        posicionOriginal = transform.position;
    }

    void Update()
    {
        // El eje "Jump" está asociado por defecto a la barra espaciadora.
        if (Input.GetAxis("Jump") > 0)
        {
            transform.position = posicionOriginal + desplazamiento;
        }
    }
}
