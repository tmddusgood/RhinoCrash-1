using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillController : MonoBehaviour
{
    public static bool skillOn = false;

    public void Skill()
    {
        if (ItemController.itemcount > 0)
        {

            skillOn = true;
            ItemController.itemcount -= 1;

        }
    }
}
