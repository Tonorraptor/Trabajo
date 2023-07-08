using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoginView : MonoBehaviour
{
    [SerializeField] private TMP_InputField nameInput = null;
    [SerializeField] private TMP_InputField passInput = null;
    [SerializeField] private TextMeshProUGUI resultT = null;
    private ConnectLogin login;

    [SerializeField] private TextMeshProUGUI nameUsu;

    private void Awake()
    {
        login = GetComponent<ConnectLogin>();
    }

    public void OnCompleted()
    {
        if (nameInput.text == "" || passInput.text == "")
        {
            resultT.text = "Llenar campos";
            return;
        }
        resultT.text = "Procesando.......";
        login.LogEnter(nameInput.text, passInput.text, delegate (LogInData data)
        {
            if (data.done == true)
            {
                resultT.text = data.message;
                SceneManager.LoadScene("MenuPrincipal");
                DatoName();
            }
            else
            {
                resultT.text = data.message;
            }
        });
    }
    public void DatoName()
    {
        nameUsu.text = nameInput.text;
    }
}
