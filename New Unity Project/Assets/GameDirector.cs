using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour {

    GameObject HpGauge;

	// Use this for initialization
	void Start () {
        this.HpGauge = GameObject.Find("HpGauge");
	}
	
	// Update is called once per frame
	public void DecreaseHp () {
        this.HpGauge.GetComponent<Image>().fillAmount -= 0.1f;
	}
}
