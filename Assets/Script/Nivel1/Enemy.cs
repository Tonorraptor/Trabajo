using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    private SendScoreController controller;
    
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<SendScoreController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }    
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}
