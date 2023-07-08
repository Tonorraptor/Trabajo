using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ScoreText : MonoBehaviour
{
    public static int score;
    public float time;
    public float maxtime;
    public TextMeshProUGUI scoreTextMesh;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        scoreTextMesh = GetComponent<TextMeshProUGUI>();
    }
    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (maxtime <= time)
        {
            score += 1;
            time = 0;

        }
        scoreTextMesh.text = "Score: " + score;
        Condition();
    }
    public void Condition()
    {
        if (score == 20)
        {
            SceneManager.LoadScene("Nivel2");
        }
    }
}
