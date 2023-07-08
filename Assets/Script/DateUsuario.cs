using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DateUsuario : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI getPlayerText;
    void Start()
    {
        getPlayerText.text = $"{LoginView.usuario}";
    }
}
