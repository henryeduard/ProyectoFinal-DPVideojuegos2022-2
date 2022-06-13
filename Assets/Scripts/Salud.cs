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

    [SerializeField] private ManejadorSonidos manejadorSonidos;

    
    void Start()
    {
        controladorVida = GameObject.Find("BarraDeVida");
        barraDeVida = controladorVida.GetComponent<BarraDeVida>();

        controladorEscena = GameObject.FindWithTag("GameController");

        vida = vidaMaxima;
        barraDeVida.IniciaBarraVida(vida);

        manejadorSonidos = FindObjectOfType<ManejadorSonidos>();
    }


    // Disminuye la vida.
    public void BajarVida(int daño) {
        vida = vida - daño;
        barraDeVida.CambiaVidaActual(vida);
        if (vida <= 0) {
            StartCoroutine(EsperaTiempo(0.8f));

            //Time.timeScale = 0;
        }
        manejadorSonidos.SeleccionaAudio(1, 0.5f);
    }

    // Corrutina para detener un momento el método que lo llame
    IEnumerator EsperaTiempo(float tiempo) {
        manejadorSonidos.SeleccionaAudio(4, 0.5f);
        yield return new WaitForSeconds(tiempo);
        Destroy(gameObject);
        controladorEscena.GetComponent<ManejadorEscenas>().PantallaInicio();

    }
}
