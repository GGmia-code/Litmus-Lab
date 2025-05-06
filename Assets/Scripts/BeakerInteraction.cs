using UnityEngine;

public class BeakerInteraction : MonoBehaviour
{
    public Material acidicMaterial;  // Material for acidic solution (Red)
    public Material neutralMaterial; // Material for neutral solution (Green)
    public Material basicMaterial;   // Material for basic solution (Blue)

    private Renderer beakerRenderer;
    private DialogueSystem dialogueSystem; // Reference to the Dialogue System to show Rick's commentary

    void Start()
    {
        // Get the renderer of the beaker
        beakerRenderer = GetComponent<Renderer>();
        // Find the DialogueSystem in the scene
        dialogueSystem = FindObjectOfType<DialogueSystem>();
    }

    void OnMouseDown()  // Detect when the player clicks on the beaker
    {
        // Display the Rick-style dialogue
        if (beakerRenderer.material == acidicMaterial)
        {
            dialogueSystem.ShowDialogue("Ugh, Morty! This one’s acidic. Look at that pH drop! What are you trying to do here?");
            beakerRenderer.material = acidicMaterial; // Ensure it stays acidic if clicked
        }
        else if (beakerRenderer.material == neutralMaterial)
        {
            dialogueSystem.ShowDialogue("Hmm, Morty... this one’s neutral. Boring. But fine, whatever.");
            beakerRenderer.material = neutralMaterial; // Ensure it stays neutral
        }
        else if (beakerRenderer.material == basicMaterial)
        {
            dialogueSystem.ShowDialogue("Yikes, Morty, this solution’s too basic. Are we trying to reverse the flow of time or something?");
            beakerRenderer.material = basicMaterial; // Ensure it stays basic
        }
    }

    // Optionally, if you'd like to add interaction via triggers (useful for dragging litmus paper)
    void OnTriggerEnter(Collider other)
    {
        // Check if the collider is the litmus paper (or any object you want to trigger the color change)
        if (other.gameObject.CompareTag("LitmusPaper"))
        {
            // You can set logic to check the type of solution and change color based on that.
            // For example, let's assume the paper interacts with the solution:
            TestSolution("acidic");  // Change to acidic for now as an example
        }
    }

    // Function to test the solution and change the color
    public void TestSolution(string solutionType)
    {
        // Change the color of the beaker based on solution type
        if (solutionType == "acidic")
        {
            beakerRenderer.material = acidicMaterial;
            dialogueSystem.ShowDialogue("Morty, this is acidic. Don't mix it up with water again, alright?");
        }
        else if (solutionType == "neutral")
        {
            beakerRenderer.material = neutralMaterial;
            dialogueSystem.ShowDialogue("This solution is neutral, Morty. No danger here.");
        }
        else if (solutionType == "basic")
        {
            beakerRenderer.material = basicMaterial;
            dialogueSystem.ShowDialogue("Too basic, Morty. We need to balance this out.");
        }
    }
}
