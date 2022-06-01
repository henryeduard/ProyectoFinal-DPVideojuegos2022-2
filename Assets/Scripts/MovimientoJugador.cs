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
    
    [SerializeField] private GameObject interfaz;

    private float movX;
    private float movY;


    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        //animador = gameObject.GetComponent<Animator>();
        //sprender = gameObject.GetComponent<SpriteRenderer>();

        interfaz = GameObject.FindWithTag("Interfaz");

    }


    // Update is called once per frame
    void FixedUpdate()
    {
        movX = 0.0f;
        movY = 0.0f;
        
        animador.SetBool("caminando", false);
    
        if (Input.GetKey(KeyCode.A))    // Izquierda
        {
            movX = -speed;
        
            animador.SetBool("caminando", true);
            sprender.flipX = true;
                        
            golpeador.eulerAngles = new Vector3(0, transform.eulerAngles.y + 180, 0);
            
        } 
        if (Input.GetKey(KeyCode.D))     // Derecha
        {
            movX = speed;

            
            animador.SetBool("caminando", true);
            sprender.flipX = false;

            golpeador.eulerAngles = new Vector3(0, transform.eulerAngles.y + 360, 0);
            

        } 
        if (Input.GetKey(KeyCode.W))     // Arriba
        {
            movY = speed;

            animador.SetBool("caminando", true);

        }
        if (Input.GetKey(KeyCode.S))      // Abajo
        {
            movY = -speed;
            animador.SetBool("caminando", true);

        } 
        if (Input.GetKey(KeyCode.P))      // Pausa
        {
            interfaz.gameObject.GetComponent<Menu>().Pausa();

        }

        rb.velocity = new Vector2(movX, movY);
    }
}
