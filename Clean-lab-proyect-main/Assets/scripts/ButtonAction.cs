using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonAction : MonoBehaviour
{
    public string tagFilter;
    public GameObject wall;
    //public Vector3 hundirse;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(tagFilter))
        {
            wall.SetActive(false);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag(tagFilter))
        {
            wall.SetActive(true);
        }
    }
}
