using UnityEngine;

public class BubblePlayer : MonoBehaviour
{
    public AudioSource bubbleSound;

    public void PlayBubbles()
    {
        if (!bubbleSound.isPlaying)
        {
            bubbleSound.Play();
        }
    }
}
