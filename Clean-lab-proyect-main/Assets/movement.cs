using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public string tagFilter;
    public string tagFilter2;

    private Rigidbody rb;

    public float speed;

    public Vector3 dir;

    private bool isPlayerOneHere = false;
    private bool isPlayerTwoHere = false;
    //public Vector3 hundirse;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (isPlayerOneHere && isPlayerTwoHere) { // Si quitais uno de los booleanos entonces la plataforma solo funciona para uno
            rb.velocity = dir * speed; // Es una guarrada pero mira asi teneis plataformas de 1 player por si quereis
        } else {
            rb.velocity = Vector3.zero;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(tagFilter))
        {
            isPlayerOneHere = true;
        } 

        if (other.CompareTag(tagFilter2))
        {
            isPlayerTwoHere = true;
        } 
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag(tagFilter))
        {
            isPlayerOneHere = false;
        } 

        if (other.CompareTag(tagFilter2))
        {
            isPlayerTwoHere = false;
        } 
    }
}