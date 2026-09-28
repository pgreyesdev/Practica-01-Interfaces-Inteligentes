using UnityEngine;

// Ejercicio 2: operaciones con dos Vector3 configurables desde el inspector.
public class Ej02_OperacionesVectores : MonoBehaviour
{
    public Vector3 vectorA = new Vector3(0.0f, 1.0f, 0.0f);
    public Vector3 vectorB = new Vector3(1.0f, 0.0f, 0.0f);

    [Header("Resultados")]
    public float magnitudA;
    public float magnitudB;
    public float angulo;
    public float distancia;
    public string vectorMasAlto;

    void Start()
    {
        Calcular();
        Debug.Log("Magnitud de A: " + magnitudA);
        Debug.Log("Magnitud de B: " + magnitudB);
        Debug.Log("Ángulo entre A y B: " + angulo + "º");
        Debug.Log("Distancia entre A y B: " + distancia);
        Debug.Log(vectorMasAlto);
    }

    // Recalcula los resultados al editar los vectores en el inspector.
    void OnValidate()
    {
        Calcular();
    }

    void Calcular()
    {
        magnitudA = vectorA.magnitude;
        magnitudB = vectorB.magnitude;
        angulo = Vector3.Angle(vectorA, vectorB);
        distancia = Vector3.Distance(vectorA, vectorB);

        if (vectorA.y > vectorB.y)
            vectorMasAlto = "El vector A está a mayor altura que el B";
        else if (vectorB.y > vectorA.y)
            vectorMasAlto = "El vector B está a mayor altura que el A";
        else
            vectorMasAlto = "Ambos vectores están a la misma altura";
    }
}
