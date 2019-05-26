using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour
{
    float speed;
    Vector3 downVector;
    public int line;
    // Use this for initialization
    void Start()
    {
        speed = GameDirector.stage == 1 ? -0.02f : -0.04f;
        this.downVector = new Vector3(0.03f, 0.03f, 0);
        if (transform.position.x == -2f)
            line = 1;
        else
            line = 2;
    }

    // Update is called once per frame
    void Update()
    {
        speed -= Time.deltaTime / 2;
        //프레임마다 등속으로 낙하시킴
        switch (line)
        {
            case 1:
                transform.Translate(1.5f * speed, speed, 0);
                break;
            case 2:
                transform.Translate(-1.5f * speed, speed, 0);
                break;
        }
        transform.localScale += downVector;

        //화면 밖으로 나갈 시 오브젝트 소멸
        if (transform.position.y < -5f)
            Destroy(gameObject);
    }
}
