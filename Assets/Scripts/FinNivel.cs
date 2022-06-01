using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinNivel : MonoBehaviour
{

    [SerializeField] private GameObject interfaz;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) 
        {
            //Time.timeScale = 0;

            interfaz.gameObject.GetComponent<Menu>().Victoria();
        }
    }
}
