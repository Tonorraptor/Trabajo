using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class Form : MonoBehaviour
{
    [SerializeField] private TMP_InputField nameInput;
    [SerializeField] private TMP_InputField passInput;
    [SerializeField] private TextMeshProUGUI resultT;
    [SerializeField] private Button execute;
    private ConectForm cForm;
    // Start is called before the first frame update
    void Start()
    {
        cForm = GetComponent<ConectForm>();
        execute.onClick.AddListener(()=>
             cForm.InsertPlayerAcept(
                string.Format (nameInput.text),
                string.Format(passInput.text),
                onCompleted)
                );
    }

    public void onCompleted(string result)
    {
        result = "Se registrop con exito";
        resultT.text = result;
    }
}
