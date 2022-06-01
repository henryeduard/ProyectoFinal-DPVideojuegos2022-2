using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaludEnemigo : MonoBehaviour
{

    [SerializeField] private int vidaMaxima;

    public int vida;

    [SerializeField] private ManejadorSonidos manejadorSonidos;

    // Start is called before the first frame update
    void Start()
    {
        vida = vidaMaxima;
        manejadorSonidos = FindObjectOfType<ManejadorSonidos>();
    }

    public void BajarVida(int daño)
    {
        vida = vida - daño;

        manejadorSonidos.SeleccionaAudio(0, 0.5f);
        if (vida <= 0)
            Destroy(gameObject);
    }
}
