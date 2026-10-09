using UnityEngine;

// Ejercicio 7: la tecla H se mapea al eje "Fire1" desde el Input Manager
// (Edit -> Project Settings -> Input Manager -> Axes -> Fire1 -> Positive Button = h).
public class Ej07_DisparoH : MonoBehaviour
{
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Debug.Log("¡Disparo!");
        }
    }
}
