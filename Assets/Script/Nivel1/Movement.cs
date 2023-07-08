using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{
    public float speed;
    public Rigidbody rb;
    public GameObject enemy;
    public float time;
    public float maxTime;

    public GameObject iPoint;
    public GameObject bullet;
    public float buelletSpeed;
    // Start is called before the first frame update
    private SendScoreController controller;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        controller = GetComponent<SendScoreController>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();
        EnemyMechanic();
    }
    public void PlayerMovement()
    {
        if (Input.GetKey("d"))
        {
            rb.velocity = transform.right * speed;
        }
        if (Input.GetKey("a"))
        {
            rb.velocity = -transform.right * speed;
        }
    }
    public void EnemyMechanic()
    {
        if (time <= 0)
        {
            time = maxTime;
            int positionEnemy = UnityEngine.Random.Range(-12, 8);
            GameObject timeEnemy = Instantiate(enemy, new Vector3(positionEnemy, 20, 0), Quaternion.identity);
            Destroy(timeEnemy, 2);
        }
        time -= Time.deltaTime;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Meteorito"))
        {                     
            SendScoreController.GetInstance().SendScore(LoginView.usuario, ScoreText.score, "Level 1", delegate (FormData data){ });            
            Destroy(collision.gameObject);
            SceneManager.LoadScene("Derrota 1");

        }
    }

}
