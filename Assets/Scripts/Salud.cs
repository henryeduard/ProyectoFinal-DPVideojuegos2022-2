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

    //Ocupado para hacer parpadear el sprite al recibir daño.
    public GameObject render;
    void Start()
    {
        //Control de la barra de vida
        controladorVida = GameObject.Find("BarraDeVida");
        barraDeVida = controladorVida.GetComponent<BarraDeVida>();

        controladorEscena = GameObject.FindWithTag("GameController");

        vida = vidaMaxima;
        barraDeVida.IniciaBarraVida(vida);

        manejadorSonidos = FindObjectOfType<ManejadorSonidos>();

        render = transform.GetChild(1).gameObject;
    }
    

    // Disminuye la vida.
    public void BajarVida(int daño) {
        vida = vida - daño;
        barraDeVida.CambiaVidaActual(vida);
        if (vida <= 0) {
            Destroy(gameObject);
            manejadorSonidos.SeleccionaAudio(4, 0.5f);

            controladorEscena.GetComponent<ManejadorEscenas>().PantallaInicio();
        }

        manejadorSonidos.SeleccionaAudio(1, 0.5f);
        StartCoroutine(ParpadeoObjeto());
    }


    IEnumerator ParpadeoObjeto()
    {
        Color color;
        for (float value = 0f; value <= 3; value++)
        {
            color = render.GetComponent<Renderer>().material.color;
            if (value % 2 == 0)
            {
                color.a = 0.5f;
            }
            else
            {
                color.a = 1f;
            }
            render.GetComponent<Renderer>().material.color = color;
            yield return new WaitForSeconds(0.08f);
        }
    }
}
