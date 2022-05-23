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

    // Corrutina que genera un nuevo enemigo cada tiempo de espera
    public IEnumerator GeneraEnemigo() {
        while(true) {
            // Esperamos el tiempo de espera 
            yield return new WaitForSeconds(tiempoEspera);
            Instantiate(enemigo, this.transform.position, this.transform.rotation);
        }
    }

}
