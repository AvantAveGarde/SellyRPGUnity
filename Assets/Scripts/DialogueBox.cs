using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DialogueBox : MonoBehaviour {
    public GameObject dialogueBox;
    public Text dialogueText;


    public bool dialogueActive;
    public string[] dialogueLines;
    public int currentLine;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (dialogueActive && Input.GetKeyDown(KeyCode.Space))
        {
            currentLine++;
        }

        if(currentLine >= dialogueLines.Length)
        {
            dialogueBox.SetActive(false);
            dialogueActive = false;
            currentLine = 0;
            SceneManager.LoadScene(0);
        }
        dialogueText.text = dialogueLines[currentLine];
    }

    public void ShowBox(string i_dialogue)
    {
        dialogueActive = true;
        dialogueBox.SetActive(true);
        dialogueText.text = i_dialogue;
    }
}
