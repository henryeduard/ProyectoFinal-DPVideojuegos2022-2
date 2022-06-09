using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaludEnemigo : MonoBehaviour
{

    [SerializeField] private int vidaMaxima;

    public int vida;

    [SerializeField] private ManejadorSonidos manejadorSonidos;

    public GameObject render;
    // Start is called before the first frame update
    void Start()
    {
        vida = vidaMaxima;
        manejadorSonidos = FindObjectOfType<ManejadorSonidos>();
        render = transform.GetChild(1).gameObject;
    }

    public void BajarVida(int daño)
    {
        vida = vida - daño;
        manejadorSonidos.SeleccionaAudio(0, 0.5f);
        
        if (vida <= 0)
            Destroy(gameObject);

        StartCoroutine(ParpadeoObjeto());
    }
    IEnumerator ParpadeoObjeto()
    {
        Color color;
        for (float value = 0f; value <=3; value++)
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
