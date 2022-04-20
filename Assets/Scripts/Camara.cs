using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour
{

    // Jugador al que seguira la camara
    public Transform jugador;
    

    // Update is called once per frame
    void FixedUpdate()
    {
        this.transform.position = new Vector3(jugador.position.x, jugador.position.y, this.transform.position.z);

    }
}
