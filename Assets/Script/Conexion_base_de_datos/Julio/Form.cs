using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class Form : MonoBehaviour
{
    [SerializeField] private TMP_InputField nameInput = null;
    [SerializeField] private TMP_InputField passInput = null;
    [SerializeField] private TMP_InputField enterPassInput = null;
    [SerializeField] private TextMeshProUGUI resultT = null;
    [SerializeField] private Button execute = null ;
    private ConectForm cForm;
    // Start is called before the first frame update
    private void Awake()
    {
        cForm = GetComponent<ConectForm>();
    }

    public void onCompleted()
    {
        if(nameInput.text=="" || passInput.text == "")
        {
            resultT.text = "Llenar campos";
            return;
        }
        if(passInput.text== enterPassInput.text)
        {
            resultT.text = "Procesando.......";
            cForm.InsertPlayerAcept(nameInput.text, passInput.text, delegate (FormData data)
            {
                resultT.text = data.messege;
            });
        }
        else
        {
            resultT.text = "Error";
        }
    }
}
