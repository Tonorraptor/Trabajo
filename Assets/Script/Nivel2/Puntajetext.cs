using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Puntajetext : MonoBehaviour
{
    private float score;
    private TextMeshProUGUI txtPuint;

    // Start is called before the first frame update
    void Start()
    {
        txtPuint = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        txtPuint.text = "Score: " + score;
    }
    public void Suma(float scoreValue)
    {
        score += scoreValue;
    }
}
