using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Salud : MonoBehaviour
{
    public int vida;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (vida <= 0)
            Destroy(gameObject);
    }

    // Disminuye la vida.
    public void BajarVida(int daño) {
        vida--;
    }
}
