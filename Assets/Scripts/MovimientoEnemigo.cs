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
    // Start is called before the first frame update
    void Start()
    {
        jugadores = GameObject.FindGameObjectsWithTag("Player");
        distAlObjetivoX = Mathf.Abs(jugadores[0].transform.position.x - transform.position.x);
        distAlObjetivoY = Mathf.Abs(jugadores[0].transform.position.y - transform.position.y);
        rb = GetComponent<Rigidbody2D>();
        
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
        }
        else 
        {
            direccionX = 0;
        }


        if (distAlObjetivoY > radioAtaqueY)
        {
            if (jugadores[0].transform.position.y > transform.position.y) direccionY = 1;
            if (jugadores[0].transform.position.y <= transform.position.y) direccionY = -1;

            
        }
        else 
        {
            direccionY = 0;
        }

        //Control de giro del enemigo
        if(direccionX > 0 && !viendoDerecha)
        {
            girar();
        }else if (direccionX < 0 && viendoDerecha)
        {
            girar();
        }


        //Esta a distancia de ataque
        if ((distAlObjetivoY <= radioAtaqueY) && (distAlObjetivoX <= radioAtaqueX))
        {
            //Atacar
            if (puedeAtacar)
            {
                gameObject.GetComponent<GolpeEnemigo>().Atacar();
                
            }
        }        
        rb.velocity = new Vector2(direccionX*velocidad, direccionY*velocidad);
    }

    private void girar()
    {
        viendoDerecha = !viendoDerecha;
        transform.eulerAngles = new Vector3(0,transform.eulerAngles.y + 180, 0);
    }
}
