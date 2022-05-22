using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Salud : MonoBehaviour
{
    public int vida;
    [SerializeField] private int vidaMaxima;

    [SerializeField] public BarraDeVida barraDeVida;
   
    // Start is called before the first frame update
    void Start()
    {
        vida = vidaMaxima;
        barraDeVida.IniciaBarraVida(vida);
    }

    //// Update is called once per frame
    //void Update()
    //{
    //    if (vida <= 0)
    //        Destroy(gameObject);
    //}

    // Disminuye la vida.
    public void BajarVida(int daño) {
        vida = vida - daño;
        barraDeVida.CambiaVidaActual(vida);
        if (vida <= 0)
            Destroy(gameObject);
    }
}
