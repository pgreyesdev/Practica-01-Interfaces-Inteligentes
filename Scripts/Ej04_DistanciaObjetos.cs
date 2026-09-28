using UnityEngine;

// Ejercicio 4: script de la esfera que muestra la distancia al cubo y al cilindro.
// El cubo y el cilindro se localizan por su etiqueta (Tag).
public class Ej04_DistanciaObjetos : MonoBehaviour
{
    public string etiquetaCubo = "cubo";
    public string etiquetaCilindro = "cilindro";

    void Start()
    {
        GameObject cubo = GameObject.FindWithTag(etiquetaCubo);
        GameObject cilindro = GameObject.FindWithTag(etiquetaCilindro);

        if (cubo == null || cilindro == null)
        {
            Debug.LogError("No se encontró el cubo o el cilindro. Revisa las etiquetas.");
            return;
        }

        Vector3 posEsfera = transform.position;
        Vector3 posCubo = cubo.GetComponent<Transform>().position;
        Vector3 posCilindro = cilindro.transform.position;

        Debug.Log("Distancia esfera - cubo: " + Vector3.Distance(posEsfera, posCubo));
        Debug.Log("Distancia esfera - cilindro: " + Vector3.Distance(posEsfera, posCilindro));
        Debug.Log("Distancia cubo - cilindro: " + Vector3.Distance(posCubo, posCilindro));
    }
}
