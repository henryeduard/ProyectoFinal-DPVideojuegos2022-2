using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GolpeJugador : MonoBehaviour
{
    // Daño que hace la proyectil
    [SerializeField]
    private int daño;


    private void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("Enemigo")){
            other.gameObject.GetComponent<Salud>().BajarVida(daño);

        }
    }
}
