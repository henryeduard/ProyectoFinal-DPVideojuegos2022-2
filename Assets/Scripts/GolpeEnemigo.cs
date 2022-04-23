using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GolpeEnemigo : MonoBehaviour
{
    public GameObject golpe;
    public float tiempoDeAtaque;
    public float tiempoEntreAtaque;
    bool puedeAtacar = true;
    
    void Start()
    {
        golpe.SetActive(false);
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

    

    public void Atacar()
    {
        if (puedeAtacar)
        {
            StartCoroutine("duracionAtaque");
            StartCoroutine("tiempoEntreAtaques");
        }
    }
}
