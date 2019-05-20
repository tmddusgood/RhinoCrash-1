using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mobGenerator : MonoBehaviour {

    public GameObject mobPrefab;
    float span = 1.0f;
    float delta = 0;
    public static int count = 0;
	
	// Update is called once per frame
	void Update () {
        //프레임의 증가에 따라 delta가 증가하면서 1.0f에 도달시 새로운 몹 생성
        this.delta += Time.deltaTime;
        if(this.delta > this.span)
        {
            count++;
            this.delta = 0;
            GameObject go = Instantiate(mobPrefab) as GameObject;
            int tmp = Random.Range(0, 4);
            float px = 0;
            switch (tmp)
            {
                case 0:
                    px = -1.3f;
                    break;
                case 1:
                    px = -0.4f;
                    break;
                case 2:
                    px = 0.4f;
                    break;
                case 3:
                    px = 1.3f;
                    break;
            }
            mobPrefab.transform.localScale = new Vector3(0.3f, 0.3f, 0);
            go.transform.position = new Vector3(px, 4.5f, 0);
        }
	}
}
