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

    public Vector3 start;
    public Vector3 end;

    private bool isPlayerOneHere = false;
    private bool isPlayerTwoHere = false;

    private float start_point;
    private float end_point;

    private float current_point;

    //public Vector3 hundirse;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        start_point = Vector3.Dot(dir, start);
        end_point = Vector3.Dot(dir, end);
    }

    void Update()
    {

        current_point = Vector3.Dot(dir, rb.position);

        if (isPlayerOneHere && isPlayerTwoHere && (current_point < end_point)) { // Si quitais uno de los booleanos entonces la plataforma solo funciona para uno
            rb.velocity = dir * speed; // Es una guarrada pero mira asi teneis plataformas de 1 player por si quereis
        } 
        else if (!isPlayerOneHere && !isPlayerTwoHere && current_point > start_point) {
            rb.velocity = -1 * dir * speed;
        }
        else if (current_point > end_point) {
            rb.velocity = Vector3.zero;
            rb.position = end;
        }
        else if (current_point < start_point) {
            rb.velocity = Vector3.zero;
            rb.position = start;
        }
        else {
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