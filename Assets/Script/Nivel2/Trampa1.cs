using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampa1 : MonoBehaviour
{
    public float speed;
    public Rigidbody rb;
    public bool change;
    public float time;
    public float maxTime;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        time = maxTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (change == true)
        {
            rb.transform.position += Vector3.right * speed * Time.deltaTime;
        }
        if (change == false)
        {
            rb.transform.position += Vector3.left * speed * Time.deltaTime;
        }
        time-=Time.deltaTime;
        if(time <= 0)
        {
            time = maxTime;
            change = !change;
        }
    } 
}
