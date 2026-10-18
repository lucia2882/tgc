using UnityEngine;

public class Camera : MonoBehaviour
{
    public KeyCode teclaActiva;
    public float velocidadGiro = 5f;
    public Transform jugador;

    // Update is called once per frame
    void Update()
    {
        if (jugador != null)
        {
            transform.position = new Vector3(jugador.position.x, jugador.position.y, transform.position.z);
        }

        if (Input.GetKey(teclaActiva))
        {
            float movimientoRaton = Input.GetAxis("Mouse X") * velocidadGiro;

            transform.Rotate(0, 0, movimientoRaton);

            if (jugador != null)
            {
                jugador.Rotate(0, 0, movimientoRaton);
            }
        }
    }
}