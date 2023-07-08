using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
public class SendScoreViewLvl2 : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI getPlayerText;
    [SerializeField]
    private TextMeshProUGUI getScoreText;

    private int scoreText;


    private SendScoreController controller;
    // Start is called before the first frame update
    void Start()
    {
        getScoreText.text = $"{Puntajetext.score}";
        getPlayerText.text = $"{LoginView.usuario}";
    }

    void Update()
    {

    }
}
