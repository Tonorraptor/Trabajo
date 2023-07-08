using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();
        EnemyMechanic();
        ShoterController();
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
            int positionEnemy = Random.Range(-12, 8);
            GameObject timeEnemy = Instantiate(enemy, new Vector3(positionEnemy, 20, 0), Quaternion.identity);
            Destroy(timeEnemy, 2);
        }
        time -= Time.deltaTime;
    }
    public void ShoterController()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            GameObject timeBullet = Instantiate(bullet, iPoint.transform.position, iPoint.transform.rotation);
            Rigidbody rgBullet = timeBullet.GetComponent<Rigidbody>();
            rgBullet.AddForce(transform.up * buelletSpeed);
            Destroy(timeBullet, 5.0F);
        }
    }
}
