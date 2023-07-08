using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class GetScoreController : MonoBehaviour
{
    public void GetScore(string username,Action<GetScoreArrayData> callback)
    {
        StartCoroutine(GetScoreRequest(username, callback));
    }

    IEnumerator GetScoreRequest(string username, Action<GetScoreArrayData> callback)
    {
        WWWForm form = new WWWForm();
        form.AddField("username", username);        

        using (UnityWebRequest www = UnityWebRequest.Post("http://localhost/progra/get_score.php", form))
        {
            yield return www.SendWebRequest();

            if (www.result == UnityWebRequest.Result.ConnectionError || www.result == UnityWebRequest.Result.ProtocolError)
            {
                Debug.Log(www.error);
            }
            else
            {
                Debug.Log(www.downloadHandler.text);
                if (www.downloadHandler.text == "null")
                {
                    callback?.Invoke(null);
                }
                else
                {
                    callback?.Invoke(JsonUtility.FromJson<GetScoreArrayData>(www.downloadHandler.text));
                }
            }
        }
    }
}
