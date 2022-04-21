using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparoAjolote : MonoBehaviour
{
    // Animator del jugador
    //private Animator animador;

    // El controlador para disparar
    [SerializeField]
    private Transform disparador;

    // Objeto prefab que será la bala
    [SerializeField]
    private GameObject bala;


    // Start is called before the first frame update
    void Start()
    {
        //animador = gameObject.GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1")) {
            Disparar();
        }
    }

    // Método que dispara instanciando una bala en nuestro disparador
    private void Disparar()
    {
        Instantiate(bala, disparador.position, disparador.rotation);
        //animador.SetTrigger("disparando");
    }
}
