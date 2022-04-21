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

        if (Input.GetKey(KeyCode.A)) 
        {
            rb.AddForce(Vector3.left * speed);
            /*animador.SetBool("izquierda",true);
            animador.SetBool("derecha",false);
            animador.SetBool("arriba",false);
            animador.SetBool("abajo",false);*/

        } else if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(Vector3.right * speed);
            /*animador.SetBool("derecha",true);
            animador.SetBool("izquierda",false);
            animador.SetBool("arriba",false);
            animador.SetBool("abajo",false);*/

        } else if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(Vector3.up * speed);
            /*animador.SetBool("arriba",true);
            animador.SetBool("izquierda",false);
            animador.SetBool("derecha",false);
            animador.SetBool("abajo",false);*/

        }else if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(Vector3.down * speed);
            /*animador.SetBool("abajo",true);
            animador.SetBool("izquierda",false);
            animador.SetBool("derecha",false);
            animador.SetBool("arriba",false);*/

        }
    }
}
