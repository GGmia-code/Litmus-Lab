using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LitmusPaper : MonoBehaviour
{
    public Material acidMaterial;
    public Material baseMaterial;
    public Material neutralMaterial;
    public TextMeshProUGUI reactionText;

    private Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
        if (reactionText != null)
            reactionText.text = "Choose a solution to test.";
    }

    public void DipInAcid()
    {
        rend.material = acidMaterial;
        reactionText.text = "Acid detected! Paper turned red.";
        StartCoroutine(AnimateText());
    }

    public void DipInBase()
    {
        rend.material = baseMaterial;
        reactionText.text = "Base detected! Paper turned blue.";
        StartCoroutine(AnimateText());
    }

    public void ResetColor()
    {
        rend.material = neutralMaterial;
        reactionText.text = "Reset. Ready for another test!";
        StartCoroutine(AnimateText());
    }

    IEnumerator AnimateText()
    {
        Vector3 originalScale = reactionText.transform.localScale;
        reactionText.transform.localScale = originalScale * 1.2f; // make it pop
        yield return new WaitForSeconds(0.1f);
        reactionText.transform.localScale = originalScale;
    }

}
