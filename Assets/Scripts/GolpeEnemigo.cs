using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GolpeEnemigo : MonoBehaviour
{

    public GameObject golpe;
    private bool golpeActivo = false;

    void Start()
    {
        golpe.SetActive(false);
    }
    
    public void Atacar()
    {
        golpeActivo = true;
        golpe.SetActive(golpeActivo);
        golpeActivo = false;
    }
}
