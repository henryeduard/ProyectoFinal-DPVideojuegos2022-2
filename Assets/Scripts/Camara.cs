using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour
{

    // Jugador al que seguira la camara
    [SerializeField]
    private GameObject jugador;

    private Transform jugadorT;


    /*private void Awake() 
    {
        jugador = GameObject.FindWithTag("Player");

    }*/
    

    // Update is called once per frame
    void FixedUpdate()
    {
        if (jugador == null) {
            jugador = GameObject.FindWithTag("Player");
            jugadorT = jugador.transform;
            Debug.Log("HOLA");
        }

        this.transform.position = new Vector3(jugadorT.position.x, this.transform.position.y , this.transform.position.z);

    }
}
