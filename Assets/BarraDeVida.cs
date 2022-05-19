using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarraDeVida : MonoBehaviour
{
    private Slider slider;
    private Animator animator;
    
    void Start()
    {
        slider = GetComponent<Slider>();
        animator = GetComponent<Animator>();
    }


    public void CambiaVidaMaxima(int vidaMaxima)
    {
        slider.maxValue = vidaMaxima;
    }

    public void CambiaVidaActual(int cantidadVida) 
    {
        slider.value = cantidadVida;
        animator.SetTrigger("Golpe");
    }

    public void IniciaBarraVida(int cantidadVida)
    {
        CambiaVidaMaxima(cantidadVida);
        CambiaVidaActual(cantidadVida);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
