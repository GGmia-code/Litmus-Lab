using UnityEngine;

public class BeakerGlow : MonoBehaviour
{
    public Material defaultMat;
    public Material glowMat;
    private Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.material = defaultMat;
    }

    void OnMouseEnter()
    {
        rend.material = glowMat;
    }

    void OnMouseExit()
    {
        rend.material = defaultMat;
    }
}
