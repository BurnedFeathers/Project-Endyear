using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuckOffWhenTouched : MonoBehaviour
{
    public GameObject DitObject;



    //private void OnTriggerEnter(Collider Player)
    //{
    //    if (Collision.)
    //    Debug.Log("Touched");
    //
    //    DitObject.GetComponent<MeshRenderer>().enabled = false;
    //    DitObject.GetComponent<MeshCollider>().enabled = false;
    //}

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            Debug.Log("Touched " + DitObject);
            
            DitObject.GetComponent<MeshRenderer>().enabled = false;
            DitObject.GetComponent<MeshCollider>().enabled = false;
        }
    }

    private void OnMouseDown()
    {
        Debug.Log("Clicked " + DitObject);

        DitObject.GetComponent<MeshRenderer>().enabled = false;
        DitObject.GetComponent<MeshCollider>().enabled = false;
    }
}
