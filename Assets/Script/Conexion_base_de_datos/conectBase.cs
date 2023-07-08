using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class conectBase : MonoBehaviour
{
    public void Start()
    {
        StartCoroutine(Conec());
    }
    IEnumerator Conec()
    { 
        using(UnityWebRequest www = UnityWebRequest.Get("http://localhost/progra/conect.php"))
        {
            yield return www.SendWebRequest();
            if(www.result==UnityWebRequest.Result.ConnectionError || www.result == UnityWebRequest.Result.ProtocolError)
            {
                Debug.Log(www.error);
            }
            else
            {
                Debug.Log(www.downloadHandler.text);
            }
        }
    }
}


