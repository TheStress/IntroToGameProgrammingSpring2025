using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

[System.Serializable]
public class DialogueData {
    public Sprite speakerImage;
    public string name;
    public string dialogueText;
}


public class W11DialogueManager : MonoBehaviour
{
    // Storing the dialogue interaction
    public List<DialogueData> dialogueData = new List<DialogueData>();
    public int dialogueIndex = 0;
    public bool dialogueRunning = false;

    // Storing the components we are setting for the game
    public TMP_Text dialogueName;
    public TMP_Text dialogueText;
    public Image dialogueImage;
    private void Update() {
        if (Input.GetKeyDown(KeyCode.Mouse0)) {
            // Checking if the dialogue was started before trying to advance to next dialogue data
            if (dialogueRunning) {
                dialogueIndex += 1;

                // Checking if the player reached the end of the dialogue interaction
                if (dialogueIndex >= dialogueData.Count) {
                    dialogueRunning = false;
                }
                else {
                    // Setting the dialogue components to the current dialogue data
                    dialogueName.text = dialogueData[dialogueIndex].name;
                    dialogueText.text = dialogueData[dialogueIndex].dialogueText;
                    dialogueImage.sprite = dialogueData[dialogueIndex].speakerImage;
                }
            }
        }

        // Triggering the start of the dialogue
        if (Input.GetKeyDown(KeyCode.Space)) {
            StartDialogue();
        }
    }

    public void StartDialogue() {
        // Starting the dialogue only if it isnt running
        if (dialogueRunning == false) {
            dialogueRunning = true; // Setting the dialogue running boolean

            dialogueIndex = 0; // Resetting the index to 0

            // Setting all the dialogue components to the current index
            dialogueName.text = dialogueData[dialogueIndex].name;
            dialogueText.text = dialogueData[dialogueIndex].dialogueText;
            dialogueImage.sprite = dialogueData[dialogueIndex].speakerImage;
        }
    }
}
