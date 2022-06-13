using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    [SerializeField] private GameObject menuPausa;

    [SerializeField] private GameObject menuVictoria;

    //[SerializeField] private GameObject barraDeVida;

    // Activa el menu de pausa el juego
    public void Pausa() {
        Time.timeScale = 0.0f;

        //barraDeVida.SetActive(false);
        menuPausa.SetActive(true);

    }

    // Quita la pausa del juego
    public void Continuar() {
        Time.timeScale = 1.0f;

        menuPausa.SetActive(false);
        menuVictoria.SetActive(false);
        //barraDeVida.SetActive(true);
    }

    // Activa el menu de victoria del juego
    public void Victoria() {
        Time.timeScale = 0.0f;

        //barraDeVida.SetActive(false);
        menuVictoria.SetActive(true);
    }

    // Manda al segundo nivel
    public void irSegundoNivel() {
        Time.timeScale = 1.0f;

        SceneManager.LoadScene("Nivel_2");
    }

    // Manda al menú principal
    public void irMenu() {
        Time.timeScale = 1.0f;

        SceneManager.LoadScene("PantallaInicio");
    }

    // Manda al menú principal
    public void Salir() {
        Debug.Log("Gracias por jugar nuestro juego.");

        Application.Quit();
    }

}
