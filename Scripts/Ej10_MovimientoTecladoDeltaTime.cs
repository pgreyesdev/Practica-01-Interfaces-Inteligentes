using UnityEngine;

// Ejercicio 10: igual que el 9 pero escalado por Time.deltaTime,
// de modo que speed pasa a ser unidades por segundo (independiente de los FPS).
public class Ej10_MovimientoTecladoDeltaTime : MonoBehaviour
{
    public float speed = 5.0f;

    public KeyCode teclaArriba = KeyCode.UpArrow;
    public KeyCode teclaAbajo = KeyCode.DownArrow;
    public KeyCode teclaIzquierda = KeyCode.LeftArrow;
    public KeyCode teclaDerecha = KeyCode.RightArrow;

    public Vector3 ejeVertical = Vector3.up;
    public Vector3 ejeHorizontal = Vector3.right;

    void Update()
    {
        float vertical = (Input.GetKey(teclaArriba) ? 1 : 0) - (Input.GetKey(teclaAbajo) ? 1 : 0);
        float horizontal = (Input.GetKey(teclaDerecha) ? 1 : 0) - (Input.GetKey(teclaIzquierda) ? 1 : 0);

        Vector3 movimiento = ejeVertical * vertical + ejeHorizontal * horizontal;
        transform.Translate(movimiento * speed * Time.deltaTime, Space.World);
    }
}
