using UnityEngine;

public class InfoToggle : MonoBehaviour
{
    public GameObject acidLabel;
    public GameObject baseLabel;
    private bool infoOn = false;

    public void ToggleInfo()
    {
        infoOn = !infoOn;
        acidLabel.SetActive(infoOn);
        baseLabel.SetActive(infoOn);
    }
}
