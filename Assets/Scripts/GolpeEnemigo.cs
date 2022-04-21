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

        // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
            golpeActivo = true;
        else
            golpeActivo = false;

        golpe.SetActive(golpeActivo);
    }
}
