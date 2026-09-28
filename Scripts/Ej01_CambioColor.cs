using UnityEngine;

// Ejercicio 1: cada 'framesEspera' frames cambia una componente aleatoria del color.
public class Ej01_CambioColor : MonoBehaviour
{
    public int framesEspera = 120;
    public float[] color = new float[3];

    private Renderer rend;
    private int contadorFrames = 0;

    void Start()
    {
        rend = GetComponent<Renderer>();
        for (int i = 0; i < color.Length; i++)
            color[i] = Random.Range(0.0f, 1.0f);
        AplicarColor();
    }

    void Update()
    {
        contadorFrames++;
        if (contadorFrames >= framesEspera)
        {
            contadorFrames = 0;
            int posicion = Random.Range(0, color.Length); // con enteros el máximo es exclusivo
            color[posicion] = Random.Range(0.0f, 1.0f);
            AplicarColor();
        }
    }

    void AplicarColor()
    {
        rend.material.color = new Color(color[0], color[1], color[2]);
    }
}
