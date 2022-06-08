using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class win : MonoBehaviour
{
    public string tagFilter;
    public string tagFilter2;

    public int Scene;

    private bool isPlayerOneHere = false;
    private bool isPlayerTwoHere = false;

    void Update()
    {
        if (isPlayerOneHere && isPlayerTwoHere) {
            SceneManager.LoadScene(Scene);
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
