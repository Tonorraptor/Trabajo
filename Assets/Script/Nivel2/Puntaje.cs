using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puntaje : MonoBehaviour
{
    public float Coin;
   [SerializeField] private Puntajetext score;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            Destroy(other.gameObject);
            Coin += 1;
            score.Suma(+1);
        }
    }

}
