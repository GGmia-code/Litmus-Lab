using UnityEngine;

public class LitmusInteraction : MonoBehaviour
{
    public Material acidMaterial;
    public Material baseMaterial;
    private Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A)) // Press A for acid reaction
        {
            GetComponent<Renderer>().material = acidMaterial;
        }
        else if (Input.GetKeyDown(KeyCode.B)) // Press B for base reaction
        {
            GetComponent<Renderer>().material = baseMaterial;
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Acid"))
        {
            rend.material = acidMaterial; // e.g. red
        }
        else if (other.CompareTag("Base"))
        {
            rend.material = baseMaterial; // e.g. blue
        }
    }
}
