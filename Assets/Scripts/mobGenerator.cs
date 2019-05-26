using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mobGenerator : MonoBehaviour {
    //public GameObject mobPrefab;
    float spawn;
    float delta = 0;
    static float[] pxBox = { -1.3f, -0.4f, 0.4f, 1.3f };
    public static int count = 0;

    private void Start()
    {
        count = 0;
        this.spawn = GameDirector.stage == 1 ? 0.4f : 0.2f;
    }

    // Update is called once per frame
    void Update () {
        //프레임의 증가에 따라 delta가 증가하면서 spqwn에 도달시 새로운 몹 생성
        this.delta += Time.deltaTime;
        if(this.delta > this.spawn)
        {
            count++;
            this.delta = 0;
            GameObject mobPrefab = Instantiate(Resources.Load("Prefab/mobPrefab")) as GameObject;
            float px = pxBox[GameDirector.rand.Next(4)];
            mobPrefab.transform.localScale = new Vector3(0.3f, 0.3f, 0);
            mobPrefab.transform.position = new Vector3(px, 4.5f, 0);
        }
        if (count > (GameDirector.stage == 1 ? 100 : 350))
        {
            SceneManager.LoadScene("StageScene");
            count = 0;
            GameObject director = GameObject.Find("GameDirector");
        }
    }
}
