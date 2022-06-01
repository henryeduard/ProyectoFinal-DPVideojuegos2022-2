using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneraEnemigos : MonoBehaviour
{

    //Tiempo de espera para generar un nuevo enemigo
    [SerializeField]
    private float tiempoEspera;

    //Objeto prefab que se va a generar (en este caso Enemigo)
    [SerializeField]
    private GameObject enemigo;


    private void Start() {
        StartCoroutine(GeneraEnemigo());
    }

    // Corrutina que genera un nuevo enemigo cada tiempo de espera.
    // Usamos un random para que los enemigos se generen a distintas "alturas" en el rango [-2,-4]
    public IEnumerator GeneraEnemigo() {
        while(true) {
            // Esperamos el tiempo de espera 
            yield return new WaitForSeconds(tiempoEspera);
            Instantiate(enemigo, this.transform.position + new Vector3(0,  Random.Range(-1.0f, 1.0f), 0), this.transform.rotation);
        }
    }

}
