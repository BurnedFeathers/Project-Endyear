using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuckOffWhenTouched : MonoBehaviour
{
    public GameObject DitObject;
    
    public Material Material;
    public float GaWegDanTime;
    private bool GaDissolvenDan;

    float x = 0;


    private void Start()
    {
        DitObject.GetComponent<MeshRenderer>().material = Material;
        GaDissolvenDan = false;
        //DitObject.GetComponent<Renderer>().material.SetFloat("_Dissolve", -1);
    }

    private void FixedUpdate()
    {
        if (GaDissolvenDan == true)
        {
            x++;
            float y = (float)(((0.04167/(GaWegDanTime-1)) * x) - 1);

            DitObject.GetComponent<Renderer>().material.SetFloat("_Dissolve", y);
        }
    }

    private void OnMouseDown()
    {
        Debug.Log("Clicked " + DitObject);

        StartCoroutine(JeMoeder());

        GaDissolvenDan = true;
    }

    IEnumerator JeMoeder()
    {
        yield return new WaitForSeconds(GaWegDanTime);

        //DitObject.GetComponent<MeshRenderer>().enabled = false;
        GaDissolvenDan = false;
    }



}
