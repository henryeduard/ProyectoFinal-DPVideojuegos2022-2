using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManejadorSonidos : MonoBehaviour
{

    /* Arreglo con los sonidos del juego
       El orden de los sonidos es el siguiente:
        0 - Daño Enemigo
        1 - Daño Jugador
        2 - Disparo
        3 - Golpe Jugador
        4 - Game Over
    */
    [SerializeField] private AudioClip[] audios;

    // Objeto que emite los sonidos
    private AudioSource controlador;

    private void Awake() {
        controlador = GetComponent<AudioSource>();

    }


    // Reproduce el sonido seleccionado del arreglo a cierto volumen
    public void SeleccionaAudio(int indice, float volumen) {
        controlador.PlayOneShot(audios[indice], volumen);

    }
}
