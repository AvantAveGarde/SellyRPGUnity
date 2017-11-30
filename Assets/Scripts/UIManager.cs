using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Slider healthBar;
    public Slider chargesBar;
    public Text HPText;
    public Text ChargesText;
    public SellyRPG.PlayerReference playerRef;
	
	//TODO:  Consider making this event based
	void Update ()
    {
        healthBar.maxValue = playerRef.playerUI.playerMaxHP;
        healthBar.value = playerRef.playerUI.playerHP;
        chargesBar.maxValue = playerRef.playerUI.playerMaxCharges;
        chargesBar.value = playerRef.playerUI.playerCharges;
	}
}
