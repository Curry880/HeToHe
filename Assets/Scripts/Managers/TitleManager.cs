using UnityEngine;

public class TitleManager : MonoBehaviour
{
    [SerializeField]
    private GameObject main;
    [SerializeField]
    private GameObject setting;

    SceneController sceneController = new SceneController();

    private void Start()
    {
        main.SetActive(true);
        setting.SetActive(false);
    }

    public void OnClickedEasy()
    {
        GameManager.currentLevel = Level.Esey;
        sceneController.ToStandBy();
    }

    public void OnClickedNormal()
    {
        GameManager.currentLevel = Level.Normal;
        sceneController.ToStandBy();
    }

    public void OnClickedHard()
    {
        GameManager.currentLevel = Level.Hard;
        sceneController.ToStandBy();
    }

    public void OnClickedGear()
    {
        main.SetActive(false);
        setting.SetActive(true);
    }

    public void OnClickedReturn()
    {
        main.SetActive(true);
        setting.SetActive(false);
    }
}
