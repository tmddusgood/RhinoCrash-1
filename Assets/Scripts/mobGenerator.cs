using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mobGenerator : MonoBehaviour {
    public GameObject[] mob;
    float spawn;
    float delta = 0;
    static float[] pxBox = { -1.3f, -0.4f, 0.4f, 1.3f };
    public static int count = 0;
    int poolSize;
    int order;

    private void Start()
    {
        poolSize = GameDirector.stage == 1 ? 20 : 40;
        mob = new GameObject[poolSize];
        for (int i = 0; i < poolSize; i++)
        {
            mob[i] = Instantiate(Resources.Load("Prefab/mobPrefab")) as GameObject;
            mob[i].SetActive(false);
        }
        this.spawn = GameDirector.stage == 1 ? 0.4f : 0.2f;
        order = 0;
    }

    // Update is called once per frame
    void Update () {
        //프레임의 증가에 따라 delta가 증가하면서 1.0f에 도달시 새로운 몹 생성
        this.delta += Time.deltaTime;
        if(this.delta > this.spawn)
        {
            order %= poolSize;
            count++;
            this.delta = 0;
            float px = pxBox[GameDirector.rand.Next(4)];
            mob[order].transform.localScale = new Vector3(0.3f, 0.3f, 0);
            mob[order].transform.position = new Vector3(px, 4.5f, 0);
            mob[order++].SetActive(true);
        }
        if (count > (GameDirector.stage == 1 ? 55 : 70))
        {
            SceneManager.LoadScene("StageScene");
            count = 0;
            GameObject director = GameObject.Find("GameDirector");
        }
    }
}
