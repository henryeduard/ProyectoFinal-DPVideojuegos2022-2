using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoJugador : MonoBehaviour
{
    // Variable para la velocidad de desplazamiento
    [SerializeField]
    private float speed;

    // Rigidbody del jugador
    private Rigidbody2D rb;

    // Animator del jugador
    //private Animator animador;


    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        //animador = gameObject.GetComponent<Animator>();

    }


    // Update is called once per frame
    void FixedUpdate()
    {

        if (Input.GetKey(KeyCode.A))    // Izquierda
        {
            //rb.AddForce(Vector3.left * speed);
            rb.velocity = new Vector2(-speed, 0.0f);

            
            /*animador.SetBool("izquierda",true);
            animador.SetBool("derecha",false);
            animador.SetBool("arriba",false);
            animador.SetBool("abajo",false);*/

        } else if (Input.GetKey(KeyCode.D))     // Derecha
        {
            //rb.AddForce(Vector3.right * speed);
            rb.velocity = new Vector2(speed, 0.0f);
            
            /*animador.SetBool("derecha",true);
            animador.SetBool("izquierda",false);
            animador.SetBool("arriba",false);
            animador.SetBool("abajo",false);*/

        } else if (Input.GetKey(KeyCode.W))     // Arriba
        {
            //rb.AddForce(Vector3.up * speed);
            rb.velocity = new Vector2(0.0f, speed);

            /*animador.SetBool("arriba",true);
            animador.SetBool("izquierda",false);
            animador.SetBool("derecha",false);
            animador.SetBool("abajo",false);*/

        }else if (Input.GetKey(KeyCode.S))      // Abajo
        {
            //rb.AddForce(Vector3.down * speed);
            rb.velocity = new Vector2(0.0f, -speed);

            /*animador.SetBool("abajo",true);
            animador.SetBool("izquierda",false);
            animador.SetBool("derecha",false);
            animador.SetBool("arriba",false);*/

        } else {
            /*rb.AddForce(Vector3.left * 0);
            rb.AddForce(Vector3.right * 0);
            rb.AddForce(Vector3.up * 0);
            rb.AddForce(Vector3.down * 0);*/
            rb.velocity = new Vector2(0.0f, 0.0f);
        }
    }
}
