using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    private int line;
    public static bool canMove = true;
    bool pastStatus = true;
    bool isChangedNow = false;
    Vector3[] linepos;
    Renderer rend;
    Color translucent;
    Color nonTransparent;

    // Use this for initialization
    void Start () {
        line = 0;
        rend = GetComponent<Renderer>();
        linepos = new Vector3[4];
        linepos[0] = new Vector3(-8.45f, -1.54f, 0);
        linepos[1] = new Vector3(-3.2f, -1.54f, 0);
        linepos[2] = new Vector3(1.7f, -1.54f, 0);
        linepos[3] = new Vector3(6.7f, -1.54f, 0);
        translucent = new Color(rend.material.color.r, rend.material.color.g, rend.material.color.b, 0.5f);
        nonTransparent = new Color(rend.material.color.r, rend.material.color.g, rend.material.color.b, 1f);
    }
	
	// Update is called once per frame
	void Update () {
        isChangedNow = false;
        if(pastStatus != canMove)
        {
            GameObject background = GameObject.Find("Black");
            background.GetComponent<BlackController>().ChangeTransperancy();
            isChangedNow = true;

            if (pastStatus)
            {
                GameObject combo = GameObject.Find("ComboGenerator");
                combo.GetComponent<ComboGenerator>().GenerateCombo(8);
            }
        }
        pastStatus = canMove;
        if (mobGenerator.count == 5)
            canMove = false;
        if (canMove && !isChangedNow)
        {
            rend.material.color = nonTransparent;
            if (Input.GetKeyDown(KeyCode.LeftArrow) && line > 0)
                line--;
            else if (Input.GetKeyDown(KeyCode.RightArrow) && line < 3)
                line++;
            transform.position = linepos[line];
        }
        else
            rend.material.color = translucent;
    }
}