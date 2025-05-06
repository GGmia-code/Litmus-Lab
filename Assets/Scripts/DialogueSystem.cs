using UnityEngine;
using UnityEngine.UI;

public class DialogueSystem : MonoBehaviour
{
    public Text dialogueText; // Reference to the UI Text element where dialogue will be displayed

    // Function to update the displayed dialogue
    public void ShowDialogue(string dialogue)
    {
        dialogueText.text = dialogue; // Update the dialogue text in the UI
    }
}
