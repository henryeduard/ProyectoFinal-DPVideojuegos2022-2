using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerJugador : MonoBehaviour
{
    
    void Start()
    {
        Instantiate(StorageJugador.jugadorPrefab,this.transform.position,this.transform.rotation);
        Destroy(this.gameObject);
    }


}
