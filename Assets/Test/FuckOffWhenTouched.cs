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

    public AudioSource Muziekie;
    public AudioClip SteenGaatKapot1;
    public AudioClip SteenGaatKapot2;
    public AudioClip SteenGaatKapot3;


    private void Start()
    {
        DitObject.GetComponent<MeshRenderer>().material = Material;
        GaDissolvenDan = false;
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

        float SuperRandom = Random.Range(1, 4);

        if (SuperRandom == 1)
        {
            Muziekie.clip = SteenGaatKapot1;
            Muziekie.Play();
            DitObject.GetComponent<MeshCollider>().enabled = false;
            Debug.Log("Steen nummer 1");
        }
        if (SuperRandom == 2)
        {
            Muziekie.clip = SteenGaatKapot2;
            Muziekie.Play();
            DitObject.GetComponent<MeshCollider>().enabled = false;
            Debug.Log("Steen nummer 2");
        }
        if (SuperRandom == 3)
        {
            Muziekie.clip = SteenGaatKapot3;
            Muziekie.Play();
            DitObject.GetComponent<MeshCollider>().enabled = false;
            Debug.Log("Steen nummer 3");
        }
    }

    IEnumerator JeMoeder()
    {
        yield return new WaitForSeconds(GaWegDanTime);

        GaDissolvenDan = false;
    }



}
