using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Puntajetext : MonoBehaviour
{
    public static int score;
    private TextMeshProUGUI txtPuint;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        txtPuint = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        txtPuint.text = "Score: " + score;
    }
    public void Suma(int scoreValue)
    {
        score += scoreValue;
    }
}
