using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GetScoreView : MonoBehaviour
{
    [SerializeField]
    private TMP_InputField usernameInputField;
    [SerializeField]
    private TextMeshProUGUI getScoreText;

    [SerializeField]
    private Button executeButton;

    [SerializeField]
    private string levelname;


    private GetScoreController controller;
    // Start is called before the first frame update
    void Start()
    {
        controller=GetComponent<GetScoreController>();
        executeButton.onClick.AddListener(() =>
            controller.GetScore(
                usernameInputField.text,
                levelname,
                OnCompleted)
            );
    }

    void OnCompleted(GetScoreArrayData data)
    {
        if (data.data == null)
        {
            getScoreText.text = $"El usuario no tiene un puntaje anterior";
        }
        else
        {
            getScoreText.text = "Los puntajes anteriores son: \n";
            foreach (var score in data.data)
            {
                getScoreText.text += $"{score.score}\n";
            }
            
        }
    }

}
