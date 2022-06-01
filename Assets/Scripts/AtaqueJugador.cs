using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtaqueJugador : MonoBehaviour
{
    // Animator del jugador
    [SerializeField]
    private Animator animador;

    // Objeto que será el golpe
    [SerializeField]
    private GameObject golpe;

    // Duracion del ataque
    [SerializeField]
    private float tiempoDeAtaque;

    // Tiempo de espera entre cada ataque
    [SerializeField]
    private float tiempoEntreAtaque;

    // Variable para ver si el jugador puede atacar o tiene que esperar
    private bool puedeAtacar = true;

    [SerializeField] private ManejadorSonidos manejadorSonidos;


    // Start is called before the first frame update
    void Start()
    {
        //animador = gameObject.GetComponent<Animator>();

        golpe.SetActive(false);
        manejadorSonidos = FindObjectOfType<ManejadorSonidos>();
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && puedeAtacar) {
            Atacar();
        }
    }


    // Método que activa el golpe para que el jugador ataque
    private void Atacar()
    {
        animador.SetTrigger("atacando");
        manejadorSonidos.SeleccionaAudio(3, 0.5f);

        StartCoroutine("duracionAtaque");
        StartCoroutine("tiempoEntreAtaques");
    }


    IEnumerator duracionAtaque() 
    {
        golpe.SetActive(true);
        yield return new WaitForSeconds(tiempoDeAtaque);
        golpe.SetActive(false);
    }


    //El tiempo entre ataques es la duracion del ataque mas el tiempo de espera.
    IEnumerator tiempoEntreAtaques()
    {
        puedeAtacar = false;
        yield return new WaitForSeconds(tiempoDeAtaque+tiempoEntreAtaque);
        puedeAtacar = true;
    }
}
