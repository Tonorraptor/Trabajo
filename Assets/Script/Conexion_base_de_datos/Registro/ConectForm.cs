using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Networking;

public class ConectForm : MonoBehaviour
{

    IEnumerator InsertPlayer(string playerName, string playerPass, Action<FormData> callback)
    {
        WWWForm form = new WWWForm();
        form.AddField("playername", playerName);
        form.AddField("playerpass", playerPass);

        using (UnityWebRequest www = UnityWebRequest.Post("http://localhost/progra/Insert_Form.php", form))
        {
            yield return www.SendWebRequest();

            if (www.result != UnityWebRequest.Result.Success)
            {
                Debug.Log(www.error);
                Debug.Log(www.error);
            }
            else
            {
                callback(JsonUtility.FromJson<FormData>(www.downloadHandler.text));
            }
        }
    }

    public void InsertPlayerAcept(string playerName, string playerPass, Action<FormData> callback)
    {
        StartCoroutine(InsertPlayer(playerName, playerPass, callback));
    }
}