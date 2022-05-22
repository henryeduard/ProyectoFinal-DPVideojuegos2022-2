using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaludEnemigo : MonoBehaviour
{
    [SerializeField] private int vidaMaxima;
    public int vida;

    // Start is called before the first frame update
    void Start()
    {
        vida = vidaMaxima;
    }

    public void BajarVida(int da�o)
    {
        vida = vida - da�o;
        if (vida <= 0)
            Destroy(gameObject);
    }
}
