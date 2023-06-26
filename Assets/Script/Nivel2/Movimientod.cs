using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Movimientod : MonoBehaviour
{
    public float speed;
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();
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
        if (Input.GetKey("w"))
        {
            rb.velocity = transform.forward * speed;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("GameOver")){
            SceneManager.LoadScene("Derrota");
        }
    }
}
