using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class Conexionabasededatos : MonoBehaviour
{
    public void GetRanking(Action<ArrayData> callback)
    {
        StartCoroutine(SendGetRankingRequest(callback));
    }

    IEnumerator SendGetRankingRequest(Action<ArrayData> callback)
    {
        using (UnityWebRequest www = UnityWebRequest.Get("http://localhost/progra/nombredelcodigo.php%22"))
        {
            yield return www.SendWebRequest();

            if (www.result == UnityWebRequest.Result.ConnectionError || www.result == UnityWebRequest.Result.ProtocolError)
            {
                Debug.Log(www.error);
            }
            else
            {
                callback?.Invoke(JsonUtility.FromJson<ArrayData>(www.downloadHandler.text));
            }
        }
    }
}
