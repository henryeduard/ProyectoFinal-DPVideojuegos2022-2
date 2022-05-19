using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtaqueCercano : MonoBehaviour
{
    [SerializeField] private float tiempoEntreDa�o;

    private float tiempoSiguienteDa�o;

    public int da�o;

    private void OnTriggerStay2D(Collider2D other)
    {
        Debug.Log(tiempoSiguienteDa�o);
        if (other.CompareTag("Player"))
        {
            tiempoSiguienteDa�o -= Time.deltaTime;

            if (tiempoSiguienteDa�o <= 0)
            {
                Debug.Log("ATACADO");
                other.GetComponent<Salud>().BajarVida(da�o);
                tiempoSiguienteDa�o = tiempoEntreDa�o;
            }
        }
    }     
}
