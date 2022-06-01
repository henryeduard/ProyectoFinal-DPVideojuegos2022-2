using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparoAjolote : MonoBehaviour
{
    // Animator del jugador
    [SerializeField]
    private Animator animador;

    // El controlador para disparar
    [SerializeField]
    private Transform disparador;

    // Objeto prefab que será la bala
    [SerializeField]
    private GameObject bala;

    [SerializeField] private ManejadorSonidos manejadorSonidos;


    // Start is called before the first frame update
    void Start()
    {
        //animador = gameObject.GetComponent<Animator>();
        manejadorSonidos = FindObjectOfType<ManejadorSonidos>();
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
        animador.SetTrigger("disparando");
        manejadorSonidos.SeleccionaAudio(2, 0.5f);
        Instantiate(bala, disparador.position, disparador.rotation);
        
    }
}
