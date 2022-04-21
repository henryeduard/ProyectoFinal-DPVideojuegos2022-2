using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proyectil : MonoBehaviour
{
    // Velocidad de disparo de la proyectil
    [SerializeField]
    private float velocidad;

    // Tiempo de vida de la proyectil
    [SerializeField]
    private float tiempoVida;

    // Daño que hace la proyectil
    [SerializeField]
    private int daño;


    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * velocidad * Time.deltaTime);
        Destroy(gameObject, tiempoVida);
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("Pared")){
            Destroy(gameObject);
        } else if(other.CompareTag("Enemigo")){
            other.gameObject.GetComponent<Salud>().BajarVida(daño);
            Destroy(gameObject);
        }
    }
}
