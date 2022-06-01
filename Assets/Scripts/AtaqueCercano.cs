using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtaqueCercano : MonoBehaviour
{
    [SerializeField] private float tiempoEntreDaño;

    private float tiempoSiguienteDaño;

    public int daño;

    private void OnTriggerStay2D(Collider2D other)
    {
        //Debug.Log(tiempoSiguienteDa�o);
        if (other.CompareTag("Player"))
        {
            tiempoSiguienteDaño -= Time.deltaTime;

            if (tiempoSiguienteDaño <= 0)
            {
                //Debug.Log("ATACADO");
                other.GetComponent<Salud>().BajarVida(daño);
                tiempoSiguienteDaño = tiempoEntreDaño;
            }
        }
    }     
}
