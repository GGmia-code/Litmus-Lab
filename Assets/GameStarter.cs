using UnityEngine;

public class GameStarter : MonoBehaviour
{
    public GameObject startPanel;
    public GameObject mainUI;

    public void BeginTest()
    {
        startPanel.SetActive(false);
        mainUI.SetActive(true);
    }
}
