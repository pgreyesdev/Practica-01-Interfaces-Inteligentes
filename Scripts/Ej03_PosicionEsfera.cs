using UnityEngine;

// Ejercicio 3: muestra en pantalla (y en consola/inspector) la posición de la esfera.
public class Ej03_PosicionEsfera : MonoBehaviour
{
    public Vector3 posicion;

    void Start()
    {
        Debug.Log("Posición de la esfera: " + transform.position);
    }

    void Update()
    {
        // Equivalente a GetComponent<Transform>().position
        posicion = transform.position;
    }

    void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 400, 25), "Posición de la esfera: " + posicion);
    }
}
