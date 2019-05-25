using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundGenerator : MonoBehaviour
{
    float treeDelta;
    float weedDelta;
    GameObject[] treeObject;
    GameObject[] weedObject;
    int treeOrder;
    int weedOrder;

    private void Start()
    {
        treeDelta = 0;
        weedDelta = 0;
        treeObject = new GameObject[10];
        weedObject = new GameObject[10];
        for(int i = 0; i < 10; i++)
        {
            treeObject[i] = Instantiate(Resources.Load("Prefab/treePrefab")) as GameObject;
            weedObject[i] = Instantiate(Resources.Load("Prefab/weedPrefab")) as GameObject;
            treeObject[i].SetActive(false);
            weedObject[i].SetActive(false);
        }
        treeOrder = 0;
        weedOrder = 0;
    }
    // Update is called once per frame
    void Update()
    {
        this.treeDelta += Time.deltaTime;
        this.weedDelta += Time.deltaTime;
        if(this.treeDelta > 0.68f)
        {
            treeOrder %= 10;
            this.treeDelta = 0;
            if(GameDirector.rand.Next() % 2 == 0)
                treeObject[treeOrder].transform.position = new Vector3(-2f, 4.5f, 1);
            else
                treeObject[treeOrder].transform.position = new Vector3(2f, 4.5f, 1);
            treeObject[treeOrder].transform.localScale = new Vector3(0.3f, 0.3f, 0);
            treeObject[treeOrder++].SetActive(true);
        }
        if(this.weedDelta > 0.4f)
        {
            weedOrder %= 10;
            this.weedDelta = 0;
            if (GameDirector.rand.Next() % 2 == 0)
                weedObject[weedOrder].transform.position = new Vector3(-2f, 4.5f, 1);
            else
                weedObject[weedOrder].transform.position = new Vector3(2f, 4.5f, 1);
            weedObject[weedOrder].transform.localScale = new Vector3(0.3f, 0.3f, 0);
            weedObject[weedOrder++].SetActive(true);
        }
    }
}
