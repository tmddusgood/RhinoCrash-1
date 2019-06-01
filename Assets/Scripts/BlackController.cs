using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackController : MonoBehaviour
{

    Renderer rend;

    // Use this for initialization
    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.material.color = new Color(rend.material.color.r, rend.material.color.g, rend.material.color.b, 0f);
        transform.position = new Vector3(0.015f, 0.036f, 0);
    }

    public void ChangeTransperancy()
    {
        //Debug.Log(rend.material.color.a.ToString());
        if (rend.material.color.a == 0f)
        {
            rend.material.color = new Color(rend.material.color.r, rend.material.color.g, rend.material.color.b, 0.5f);
            Debug.Log("change transperancy 0.5");
        }
        else
        {
            rend.material.color = new Color(rend.material.color.r, rend.material.color.g, rend.material.color.b, 0f);
            Debug.Log("change transperancy 0");
        }
    }
}