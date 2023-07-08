using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Networking;

public class ConnectLogin : MonoBehaviour
{
    IEnumerator LogPlayer(string playerName, string playerPass, Action<LogInData> callback)
    {
        WWWForm form = new WWWForm();
        form.AddField("playername", playerName);
        form.AddField("playerpass", playerPass);

        using (UnityWebRequest www = UnityWebRequest.Post("http://localhost/progra/Insert_LogIn.php", form))
        {
            yield return www.SendWebRequest();

            callback(JsonUtility.FromJson<LogInData>(www.downloadHandler.text));
        }
    }

    public void LogEnter(string playerName, string playerPass, Action<LogInData> callback)
    {
        StartCoroutine(LogPlayer(playerName, playerPass, callback));
    }
}
