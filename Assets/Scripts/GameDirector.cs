using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameDirector : MonoBehaviour {

    GameObject hpGauge;
    public static int stage = 0;
    public static int HP = 10;
  
    public static System.Random rand = new System.Random();
    // Use this for initialization
    void Start () {
        this.hpGauge = GameObject.Find("hpGauge");
        stage++;
        Debug.Log(stage.ToString() + "Stage start");
	}
	
	public void DecreaseHp()
    {
        this.hpGauge.GetComponent<Image>().fillAmount -= 0.1f;
        GameDirector.HP--;
        Debug.Log("collision detected");
    }

    public void Dead()
    {
        SceneManager.LoadScene("DeadScene");
        mobGenerator.count = 0;
        ItemController.itemcount = 0;
        GameDirector.stage = 0;
        GameDirector.HP = 10;
    }
}
