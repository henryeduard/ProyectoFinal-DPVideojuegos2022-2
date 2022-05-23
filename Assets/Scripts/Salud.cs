using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Salud : MonoBehaviour
{
    public int vida;
    [SerializeField] private int vidaMaxima;

    private GameObject controladorVida;
    private BarraDeVida barraDeVida;
    public GameObject controladorEscena;

    
    void Start()
    {
        controladorVida = GameObject.Find("BarraDeVida");
        barraDeVida = controladorVida.GetComponent<BarraDeVida>();

        controladorEscena = GameObject.FindWithTag("GameController");

        vida = vidaMaxima;
        barraDeVida.IniciaBarraVida(vida);
    }


    // Disminuye la vida.
    public void BajarVida(int daño) {
        vida = vida - daño;
        barraDeVida.CambiaVidaActual(vida);
        if (vida <= 0) {
            Destroy(gameObject);

            controladorEscena.GetComponent<ManejadorEscenas>().PantallaInicio();
            
            //Time.timeScale = 0;
        }
    }
}
