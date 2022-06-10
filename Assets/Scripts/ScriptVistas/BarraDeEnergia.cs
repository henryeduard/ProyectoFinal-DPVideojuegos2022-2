using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarraDeEnergia : MonoBehaviour
{
    private Slider slider;
    private Animator animator;

    

    private float tiempoMilisegundos;

    public void GolpeRecarga()
    {
        StartCoroutine(RecargaEnergia());
    }


    IEnumerator RecargaEnergia()
    {
        for(float value = 0f; value <= tiempoMilisegundos; value++)
        {
            slider.value = value;
            yield return new WaitForSeconds(0.1f);
        }
    }


    public void IniciaBarraEnergia(float tiempoEspera)
    {

        slider = GetComponent<Slider>();
        animator = GetComponent<Animator>();

        tiempoMilisegundos = tiempoEspera * 10f;
        slider.maxValue = tiempoMilisegundos;
        slider.value = tiempoMilisegundos;  
    }
}