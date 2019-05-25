using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour {

    GameObject hpGauge;
    public static int stage = 0;
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
        Debug.Log("collision detected");
    }
}
