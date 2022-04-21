using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoEnemigo : MonoBehaviour
{
    public GameObject[] jugadores;

    //Valores para que el enemigo pueda atacar
    public float radioAtaqueX;
    public float radioAtaqueY;

    int direccionX;
    int direccionY;

    private float distAlObjetivoX;
    private float distAlObjetivoY;
    // Start is called before the first frame update
    void Start()
    {
        jugadores = GameObject.FindGameObjectsWithTag("Player");
        distAlObjetivoX = Mathf.Abs(jugadores[0].transform.position.x - transform.position.x);
        distAlObjetivoY = Mathf.Abs(jugadores[0].transform.position.y - transform.position.y);

    }

    // Update is called once per frame
    void Update()
    {

        //Si no esta a radio de ataque, muevete e intenta igualar la posicion.
        if(distAlObjetivoX > radioAtaqueX) 
        { 
            if (jugadores[0].transform.position.x > transform.position.x) direccionX = 1;
            if (jugadores[0].transform.position.x <= transform.position.x) direccionX = -1;
        }
        if (distAlObjetivoY > radioAtaqueY)
        {
            if (jugadores[0].transform.position.y > transform.position.y) direccionY = 1;
            if (jugadores[0].transform.position.y <= transform.position.y) direccionY = -1;
        }

        if((distAlObjetivoY <= radioAtaqueY) && (distAlObjetivoX <= radioAtaqueX))
        {
            //ataca
        }


    }
}
