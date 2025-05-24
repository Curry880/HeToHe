using UnityEngine.SceneManagement;

public class SceneController
{
    public void ToTitle()
    {
        SceneManager.LoadScene("Title");
    }
    public void ToStandBy()
    {
        SceneManager.LoadScene("StandBy");
    }
    public void ToGame()
    {
        SceneManager.LoadScene("InGame");
    }
    public void ToResult()
    {
        SceneManager.LoadScene("Result");
    }
}
