using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {
    public Slider healthBar;
    public Slider chargesBar;
    public Text HPText;
    public Text ChargesText;
    public PlayerUIManager playerUIManger;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        healthBar.maxValue = playerUIManger.playerMaxHP;
        healthBar.value = playerUIManger.playerHP;
        chargesBar.maxValue = playerUIManger.playerMaxCharges;
        chargesBar.value = playerUIManger.playerCharges;
	}
}
