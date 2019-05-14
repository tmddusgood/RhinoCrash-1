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
    }

    public void ChangeTransperancy()
    {
        if (rend.material.color.a == 1f)
            rend.material.color = new Color(rend.material.color.r, rend.material.color.g, rend.material.color.b, 0.5f);
        else
            rend.material.color = new Color(rend.material.color.r, rend.material.color.g, rend.material.color.b, 0f);
    }
}