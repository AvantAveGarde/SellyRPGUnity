using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Slider healthBar;
    public Slider chargesBar;
    public Text HPText;
    public Text ChargesText;
    public PlayerUIManager playerUIManger;
	
	//TODO:  Consider making this event based
	void Update ()
    {
        healthBar.maxValue = playerUIManger.playerMaxHP;
        healthBar.value = playerUIManger.playerHP;
        chargesBar.maxValue = playerUIManger.playerMaxCharges;
        chargesBar.value = playerUIManger.playerCharges;
	}
}
