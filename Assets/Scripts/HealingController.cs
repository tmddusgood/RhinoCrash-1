using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealingController : MonoBehaviour
{
    public List<GameObject> HealingList = new List<GameObject>();
    public static int healingcount = 0;

    public static int i = 0;

    public void Start()
    {
        for (i = 0; i < HealingList.Capacity; i++)
            Destroy(HealingList[i]);
        //HealingList.Clear();


        for (i = 0; i < 5; i++)
        {
            GameObject _obj = Instantiate(Resources.Load("Prefab/healingPrefab 1")) as GameObject;
            HealingList.Add(_obj);
            HealingList[i].transform.localScale = new Vector3(1f, 1f, 0);
            HealingList[i].transform.localPosition = new Vector3(-9 + i, 1, 0);
            HealingList[i].SetActive(false);
            //HealingList[i].SetActive(true);

        }

        Healing();
    }

    //public void Reset()
    //{
    //    for (int i = 0; i < HealingList.Capacity; i++)
    //        Destroy(HealingList[i]);
    //    //HealingList.Clear();
    //    for (int i = 0; i < 5; i++)
    //    {
    //        GameObject _obj = Instantiate(Resources.Load("Prefab/healingPrefab 1")) as GameObject;
    //        HealingList.Add(_obj);
    //        HealingList[i].transform.localScale = new Vector3(1f, 1f, 0);
    //        HealingList[i].transform.localPosition = new Vector3(-9 + i, 1, 0);
    //        HealingList[i].SetActive(false);
    //        //HealingList[i].SetActive(true);

    //    }
    //}

    public void Healing()
    {
        for (i = 0; i < 5; i++)
        {
            HealingList[i].SetActive(false);
        }
        
        for (int j = 0; j < healingcount; j++)
        {
            HealingList[j].SetActive(true);
        }
    }
}
