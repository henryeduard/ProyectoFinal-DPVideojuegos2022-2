using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtaqueCercano : MonoBehaviour
{
    public int da�o;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.TryGetComponent(out Salud e))
        {
            Atacar(e);
        }
    }

    public void Atacar(Salud s)
    {
        s.vida -= da�o;
    }
}
