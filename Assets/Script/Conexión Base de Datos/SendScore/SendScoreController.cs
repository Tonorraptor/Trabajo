using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class SendScoreController : MonoBehaviour
{
    private static SendScoreController instance;
    public void SendScore(string username, int score, Action<FormData> callback)
    {
        StartCoroutine(SendScoreRequest(username, score, callback));
    }
    public static SendScoreController GetInstance()
    {
        return instance;
    }
    void Awake()
    {
        instance = this;
    }

    IEnumerator SendScoreRequest(string username, int score,Action<FormData> callback)
    {
        WWWForm form = new WWWForm();
        form.AddField("playername", "aaa");
        form.AddField("score", score);
        form.AddField("levelname", "Level 1");
        
        using (UnityWebRequest www = UnityWebRequest.Post("http://localhost/progra/insert_score.php", form))
        {
                        
            var response =  www.SendWebRequest();
           
            yield return response;
           
                      
        }
    }
}
