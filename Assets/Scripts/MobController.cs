﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobController : MonoBehaviour
{
    GameObject player;
    Vector3 downVector;
    public int line;
    float speed;

    // Use this for initialization
    void Start()
    {
        this.player = GameObject.Find("player"); //player 오브젝트 찾아서 객체로 추가
        this.downVector = new Vector3(0.03f, 0.03f, 0);
        speed = GameDirector.stage == 1 ? -0.02f : -0.04f;
        if (transform.position.x == -1.3f)
            line = 1;
        else if (transform.position.x == -0.4f)
            line = 2;
        else if (transform.position.x == 0.4f)
            line = 3;
        else
            line = 4;
        Debug.Log("pool = " + transform.position.x.ToString());
    }

    // Update is called once per frame
    void Update()
    {
        //프레임마다 등속으로 낙하시킴
        speed -= Time.deltaTime / 2;
        switch (line)
        {
            case 1:
                transform.Translate(0.7f * speed, speed, 0);
                break;
            case 2:
                transform.Translate(0.2f * speed, speed, 0);
                break;
            case 3:
                transform.Translate(-0.2f * speed, speed, 0);
                break;
            case 4:
                transform.Translate(-0.7f * speed, speed, 0);
                break;
        }
        transform.localScale += downVector;



        //화면 밖으로 나갈 시 오브젝트 소멸
        if (transform.position.y < -3.5f)
            Destroy(gameObject);

        //충돌 판정
        Vector2 p1 = transform.position; //화살 중심 좌표
        Vector2 p2 = this.player.transform.position; //플레이어의 중심 좌표
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;
        float r1 = 0.5f; //몹 반경
        float r2 = 1.0f; //플레이어 반경

        if (!SkillController.skillOn)
        {
            if (d < r1 + r2)
            {
                //충돌시 몹을 소멸시킨다.
                Destroy(gameObject);


                //감독 스크립트에 플레이어와 몹이 충돌했다고 전달
                GameObject director = GameObject.Find("GameDirector");
                director.GetComponent<GameDirector>().DecreaseHp();
            }
        }

        if (GameDirector.HP <= 0)
        {
            GameObject director = GameObject.Find("GameDirector");
            director.GetComponent<GameDirector>().Dead();
        }
    }
}
