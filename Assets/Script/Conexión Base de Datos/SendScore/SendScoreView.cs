using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SendScoreView : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI getPlayerText;
    [SerializeField]
    private TextMeshProUGUI getScoreText;
    public ScoreText scoreText;
    

    private SendScoreController controller;
    // Start is called before the first frame update
    void Start()
    {
        scoreText = GetComponent<ScoreText>();
    }

    void Update()
    {
        //getPlayerText.text = data.username;
        //int score = ScoreText.score;
        //getScoreText.text = ScoreText.score;
    }
    /*
    void OnCompleted()
    {
        SceneManager.LoadScene("RankingScene");
    }*/
}
