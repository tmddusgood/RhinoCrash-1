using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillController : MonoBehaviour
{
    public static bool skillOn = false;
    public static bool healingOn = false;

    public void Skill()
    {
        if (ItemController.itemcount > 0)
        {
            skillOn = true;
            ItemController.itemcount -= 1;

        }
    }

    public void Skillhealing()
    {
        if (HealingController.healingcount > 0)
        {

            healingOn = true;
            HealingController.healingcount -= 1;

        }
    }
   

    //public static DateTime Delay(int MS)
    //{
    //    DateTime ThisMoment = DateTime.Now;
    //    TimeSpan duration = new TimeSpan(0, 0, 0, 0, MS);
    //    DateTime AfterWards = ThisMoment.Add(duration);

    //    while (AfterWards >= ThisMoment)
    //    {
    //        System.Windows.Forms.Application.DoEvents();
    //        ThisMoment = DateTime.Now;
    //    }

    //    return DateTime.Now;
    //}
}
