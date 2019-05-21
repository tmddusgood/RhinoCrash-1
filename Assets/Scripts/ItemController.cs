using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemController : MonoBehaviour
{
    List<GameObject> ItemList = new List<GameObject>();
    public static int itemcount = 0;

    public void Item()
    {
        for (int i = 0; i < 3; i++)
        {
            GameObject _obj = Instantiate(Resources.Load("Prefab/item 1")) as GameObject;
            ItemList.Add(_obj);
            ItemList[i].transform.localScale = new Vector3(0.5f, 0.5f, 0);
            ItemList[i].transform.localPosition = new Vector3(-9 + i, 3, 0);
            ItemList[i].SetActive(false);
            //ItemList[i].SetActive(true);
        }

        for (int j = 0; j < itemcount; j++)
        {
            ItemList[j].SetActive(true);
        }

    }
}
