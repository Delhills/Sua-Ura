using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rig : MonoBehaviour
{
    private Rigidbody rb;
    public float speed;
    public GameObject player;
    public Vector3 respawnPoint;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        //Debug.Log(rb);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerpos = player.transform.position;
        Vector3 ballpos = rb.position;
        Vector3 movement = playerpos - ballpos;

        movement.y = 0.0f;
        movement.Normalize();
        rb.AddForce(movement * speed);

        if (transform.position.y < -5){
            transform.position = respawnPoint;
        }
    }
}
