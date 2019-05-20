using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComboGenerator : MonoBehaviour
{
    public List<GameObject> arrowList;
    public bool stop = false;
    public int order = 0;

    private void Update()
    {
        if (stop)
        {
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                if (arrowList[order].transform.localScale.x == 0.5f)
                    arrowList[order++].transform.GetComponent<Renderer>().material.color = Color.red;
                else
                {
                    for (int i = 0; i < arrowList.Capacity; i++)
                        arrowList[i].transform.GetComponent<Renderer>().material.color = Color.white;
                    order = 0;
                }
            }
            else if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                if (arrowList[order].transform.localScale.x == -0.5f)
                    arrowList[order++].transform.GetComponent<Renderer>().material.color = Color.red;
                else
                {
                    for (int i = 0; i < arrowList.Capacity; i++)
                        arrowList[i].transform.GetComponent<Renderer>().material.color = Color.white;
                    order = 0;
                }
            }

            if (arrowList.Capacity == order)
            {
                for (int i = 0; i < arrowList.Capacity; i++)
                    Destroy(arrowList[i]);
                arrowList.Clear();
                stop = false;
                PlayerController.canMove = true;
                order = 0;
            }
        }
    }

    public void GenerateCombo(int num)
    {
        arrowList.Clear();
        int randNum = mobGenerator.rand.Next();
        float xpos = -10f;
        for (int i = 0; i < num; i++)
        {
            GameObject arrow = Instantiate(Resources.Load("Prefab/LeftPrefab")) as GameObject;
            arrow.transform.position = new Vector3(xpos, 4.3f, -2f);
            if (randNum % 2 == 0)
                arrow.transform.localScale = new Vector3(0.5f, 0.5f, 0);
            else
                arrow.transform.localScale = new Vector3(-0.5f, 0.5f, 0);
            arrowList.Add(arrow);
            //arrow = null;
            randNum /= 2;
            xpos += 1f;
        }
        stop = true;
        //arrowList[0].transform.GetComponent<Renderer>().material.color = Color.white;
        //arrowList[1].transform.GetComponent<Renderer>().material.color = Color.red;
    }
}
