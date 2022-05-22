using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarraDeVida : MonoBehaviour
{
    private Slider slider;
    private Animator animator;
    

    public void CambiaVidaMaxima(float vidaMaxima)
    {
        slider.maxValue = vidaMaxima;
    }

    public void CambiaVidaActual(float cantidadVida) 
    {
        slider.value = cantidadVida;
        animator.SetTrigger("Golpe");
    }

    public void IniciaBarraVida(float cantidadVida)
    {
        slider = GetComponent<Slider>();
        animator = GetComponent<Animator>();

        CambiaVidaMaxima(cantidadVida);
        CambiaVidaActual(cantidadVida);
        
    }

}
