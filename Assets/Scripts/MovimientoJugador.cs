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
    [SerializeField]
    private Animator animador;

    // SpriteRenderer del jugador
    [SerializeField]
    private SpriteRenderer sprender;

    // Zona de golpe del jugador
    [SerializeField]
    private Transform golpeador;


    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        //animador = gameObject.GetComponent<Animator>();
        //sprender = gameObject.GetComponent<SpriteRenderer>();

    }


    // Update is called once per frame
    void FixedUpdate()
    {

        if (Input.GetKey(KeyCode.A))    // Izquierda
        {
            //rb.AddForce(Vector3.left * speed);
            rb.velocity = new Vector2(-speed, 0.0f);

            animador.SetBool("caminando", true);
            sprender.flipX = true;

            //golpeador.transform.eulerAngles = new Vector3(0, transform.eulerAngles.y + 180, 0);
            golpeador.eulerAngles = new Vector3(0, transform.eulerAngles.y + 180, 0);
            //golpeador.transform.Rotate(0, 180, 0);

        } else if (Input.GetKey(KeyCode.D))     // Derecha
        {
            //rb.AddForce(Vector3.right * speed);
            rb.velocity = new Vector2(speed, 0.0f);
            
            animador.SetBool("caminando", true);
            sprender.flipX = false;

            //golpeador.transform.eulerAngles = new Vector3(0, transform.eulerAngles.y + 360, 0);
            golpeador.eulerAngles = new Vector3(0, transform.eulerAngles.y + 360, 0);
            //golpeador.transform.Rotate(0, 180, 0);

        } else if (Input.GetKey(KeyCode.W))     // Arriba
        {
            //rb.AddForce(Vector3.up * speed);
            rb.velocity = new Vector2(0.0f, speed);

            animador.SetBool("caminando", true);

        }else if (Input.GetKey(KeyCode.S))      // Abajo
        {
            //rb.AddForce(Vector3.down * speed);
            rb.velocity = new Vector2(0.0f, -speed);

            animador.SetBool("caminando", true);

        } else {
            /*rb.AddForce(Vector3.left * 0);
            rb.AddForce(Vector3.right * 0);
            rb.AddForce(Vector3.up * 0);
            rb.AddForce(Vector3.down * 0);*/
            rb.velocity = new Vector2(0.0f, 0.0f);

            animador.SetBool("caminando", false);
        }
    }
}
