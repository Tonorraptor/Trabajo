using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    
    public void Menu()
    {
        SceneManager.LoadScene("MenuPrincipal");
    }
    public void Return()
    {
        SceneManager.LoadScene("Nivel1");
    }
    public void Return2()
    {
        SceneManager.LoadScene("Nivel2");
    }
    public void Creditos()
    {
        SceneManager.LoadScene("Creditos");
    }
    public void ExitGame()
    {
        Application.Quit();
    }
    public void LogIn()
    {
        SceneManager.LoadScene("Login");
    }
    public void Form()
    {
        SceneManager.LoadScene("Crear");
    }
}
