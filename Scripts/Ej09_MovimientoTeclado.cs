using UnityEngine;

// Ejercicio 9: movimiento con teclas configurables en el inspector.
// Cubo: flechas. Esfera: W-S (vertical) y A-D (horizontal).
public class Ej09_MovimientoTeclado : MonoBehaviour
{
    public float speed = 0.1f;

    public KeyCode teclaArriba = KeyCode.UpArrow;
    public KeyCode teclaAbajo = KeyCode.DownArrow;
    public KeyCode teclaIzquierda = KeyCode.LeftArrow;
    public KeyCode teclaDerecha = KeyCode.RightArrow;

    // Ejes del mundo en los que se traducen el movimiento vertical y horizontal.
    public Vector3 ejeVertical = Vector3.up;
    public Vector3 ejeHorizontal = Vector3.right;

    void Update()
    {
        float vertical = (Input.GetKey(teclaArriba) ? 1 : 0) - (Input.GetKey(teclaAbajo) ? 1 : 0);
        float horizontal = (Input.GetKey(teclaDerecha) ? 1 : 0) - (Input.GetKey(teclaIzquierda) ? 1 : 0);

        Vector3 movimiento = ejeVertical * vertical + ejeHorizontal * horizontal;
        transform.Translate(movimiento * speed, Space.World);
    }
}
