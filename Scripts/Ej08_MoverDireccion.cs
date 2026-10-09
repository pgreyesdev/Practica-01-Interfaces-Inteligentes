using UnityEngine;

// Ejercicio 8: traslada el cubo en cada frame según moveDirection * speed.
public class Ej08_MoverDireccion : MonoBehaviour
{
    public Vector3 moveDirection = new Vector3(1.0f, 0.0f, 0.0f);
    public float speed = 2.0f;
    // Space.Self: ejes locales del cubo. Space.World: ejes del mundo.
    public Space sistemaReferencia = Space.Self;

    void Update()
    {
        transform.Translate(moveDirection.x * speed,
                            moveDirection.y * speed,
                            moveDirection.z * speed,
                            sistemaReferencia);
    }
}
