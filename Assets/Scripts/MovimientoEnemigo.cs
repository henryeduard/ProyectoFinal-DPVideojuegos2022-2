using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoEnemigo : MonoBehaviour
{
    public GameObject[] jugadores;

    //Valores para que el enemigo pueda atacar
    public float radioAtaqueX;
    public float radioAtaqueY;

    public float velocidad;

    int direccionX;
    int direccionY;

    private float distAlObjetivoX;
    private float distAlObjetivoY;

    private bool viendoDerecha = false;
    private bool puedeAtacar = true;

    Rigidbody2D rb;

    // Animator del jugador
    [SerializeField]
    private Animator animador;

    // SpriteRenderer del jugador
    [SerializeField]
    private SpriteRenderer sprender;


    // Start is called before the first frame update
    void Start()
    {
        jugadores = GameObject.FindGameObjectsWithTag("Player");
        distAlObjetivoX = Mathf.Abs(jugadores[0].transform.position.x - transform.position.x);
        distAlObjetivoY = Mathf.Abs(jugadores[0].transform.position.y - transform.position.y);
        rb = GetComponent<Rigidbody2D>();
        sprender.flipX = true;
        
    }

    

    private void FixedUpdate()
    {

        distAlObjetivoX = Mathf.Abs(jugadores[0].transform.position.x - transform.position.x);
        distAlObjetivoY = Mathf.Abs(jugadores[0].transform.position.y - transform.position.y);

        //Si no esta a radio de ataque, muevete e intenta igualar la posicion.
        if (distAlObjetivoX > radioAtaqueX)
        {
            if (jugadores[0].transform.position.x > transform.position.x)  direccionX = 1;
            if (jugadores[0].transform.position.x <= transform.position.x) direccionX = -1;

            //animador.SetBool("caminando", true);
            animador.SetBool("caminando", false);
        }
        else 
        {
            direccionX = 0;
            animador.SetBool("caminando", false);
        }


        if (distAlObjetivoY > radioAtaqueY)
        {
            if (jugadores[0].transform.position.y > transform.position.y) direccionY = 1;
            if (jugadores[0].transform.position.y <= transform.position.y) direccionY = -1;

            //animador.SetBool("caminando", true);
            animador.SetBool("caminando", false);
        }
        else 
        {
            direccionY = 0;
            animador.SetBool("caminando", false);
        }

        animador.SetBool("caminando", true);

        //Control de giro del enemigo
        if(direccionX > 0 && !viendoDerecha)
        {
            girar();
            //sprender.flipX = false;

        }else if (direccionX < 0 && viendoDerecha)
        {
            girar();
            //sprender.flipX = true;

        }


        //Esta a distancia de ataque
        if ((distAlObjetivoY <= radioAtaqueY) && (distAlObjetivoX <= radioAtaqueX))
        {
            //Atacar
            if (puedeAtacar)
            {
                gameObject.GetComponent<GolpeEnemigo>().Atacar();
                animador.SetTrigger("atacando");

            }
        }        
        rb.velocity = new Vector2(direccionX*velocidad, direccionY*velocidad*0.5f);
    }

    private void girar()
    {
        viendoDerecha = !viendoDerecha;
        transform.eulerAngles = new Vector3(0,transform.eulerAngles.y + 180, 0);
        
    }
}
