using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mobGenerator : MonoBehaviour {

    public GameObject[,] mobPrefab;
    int[] order;
    float span = 0.5f;
    float delta = 0;
    public static int count = 0;
    public static System.Random rand = new System.Random();

    private void Start()
    {
        order = new int[4];
        mobPrefab = new GameObject[4,5];
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                mobPrefab[i, j] = Instantiate(Resources.Load("Prefab/mobPrefab")) as GameObject;
                mobPrefab[i, j].SetActive(false);
            }
            order[i] = 0;
        }
    }

    // Update is called once per frame
    void Update () {
        //프레임의 증가에 따라 delta가 증가하면서 1.0f에 도달시 새로운 몹 생성
        this.delta += Time.deltaTime;
        if(this.delta > this.span)
        {
            count++;
            this.delta = 0;
            int line = rand.Next(4);

            mobPrefab[line, order[line]].transform.localScale = new Vector3(.3f, .3f, 0);
            if (line == 0)
                mobPrefab[line, order[line]].transform.position = new Vector3(-1.3f, 4.5f, 0);
            else if (line == 1)
                mobPrefab[line, order[line]].transform.position = new Vector3(-.4f, 4.5f, 0);
            else if (line == 2)
                mobPrefab[line, order[line]].transform.position = new Vector3(.4f, 4.5f, 0);
            else
                mobPrefab[line, order[line]].transform.position = new Vector3(1.3f, 4.5f, 0);

            mobPrefab[line, order[line]++].SetActive(true);
            order[line] %= 5;
        }
    }
}
