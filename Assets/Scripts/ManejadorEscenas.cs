using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManejadorEscenas : MonoBehaviour
{
    public void PantallaInicio() 
    {
        SceneManager.LoadScene("PantallaInicio");
    }

    public void SeleccionPersonaje()
    {
        SceneManager.LoadScene("SeleccionPersonaje");
    }

    public void Nivel_1()
    {
        SceneManager.LoadScene("Nivel_1");
    }

    
}
