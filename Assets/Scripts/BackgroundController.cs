using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour
{

    Vector3 downVector;
    public int line;
    // Use this for initialization
    void Start()
    {
        this.downVector = new Vector3(0.03f, 0.03f, 0);
        if (transform.position.x == -2f)
            line = 1;
        else
            line = 2;
    }

    // Update is called once per frame
    void Update()
    {
        //프레임마다 등속으로 낙하시킴
        switch (line)
        {
            case 1:
                transform.Translate(1.5f * MobController.speed, MobController.speed, 0);
                break;
            case 2:
                transform.Translate(-1.5f * MobController.speed, MobController.speed, 0);
                break;
        }
        transform.localScale += downVector;



        //화면 밖으로 나갈 시 오브젝트 소멸
        if (transform.position.y < -5f)
            Destroy(gameObject);
    }
}
