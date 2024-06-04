using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuckOffWhenTouched : MonoBehaviour
{
    public GameObject DitObject;


    private void OnMouseDown()
    {
        Debug.Log("Clicked " + DitObject);

        DitObject.GetComponent<MeshRenderer>().enabled = false;
    }
}
