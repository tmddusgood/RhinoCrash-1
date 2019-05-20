using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundGenerator : MonoBehaviour
{
    float treeDelta;
    float weedDelta;
    System.Random rand;

    private void Start()
    {
        treeDelta = 0;
        weedDelta = 0;
        rand = new System.Random();
    }
    // Update is called once per frame
    void Update()
    {
        this.treeDelta += Time.deltaTime;
        this.weedDelta += Time.deltaTime;
        if(this.treeDelta > 0.68f)
        {
            this.treeDelta = 0;
            GameObject tree = Instantiate(Resources.Load("Prefab/treePrefab")) as GameObject;
            if(rand.Next() % 2 == 0)
                tree.transform.position = new Vector3(-2f, 4.5f, 1);
            else
                tree.transform.position = new Vector3(2f, 4.5f, 1);
            tree.transform.localScale = new Vector3(0.3f, 0.3f, 0);
        }
        if(this.weedDelta > 0.4f)
        {
            this.weedDelta = 0;
            GameObject weed = Instantiate(Resources.Load("Prefab/weedPrefab")) as GameObject;
            if (rand.Next() % 2 == 0)
                weed.transform.position = new Vector3(-2f, 4.5f, 1);
            else
                weed.transform.position = new Vector3(2f, 4.5f, 1);
            weed.transform.localScale = new Vector3(0.3f, 0.3f, 0);
        }
        //GameObject tree = Instantiate(Resources.Load("Prefab/treePrefafb")) as GameObject;
        //GameObject weed = Instantiate(Resources.Load("Prefab/weedPrefafb")) as GameObject;
    }
}
