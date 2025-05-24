using UnityEngine;
using UnityEngine.UI;

public class ResultManager : MonoBehaviour
{
    [SerializeField]
    private Text rateText;
    [SerializeField] 
    private Text correctText;
    [SerializeField] 
    private Text timerText;
    [SerializeField]
    private Text resultText ;

    SceneController sceneController = new SceneController();

    void Start()
    {
        float rate = (float)GameManager.numOfCorrects / (float)GameManager.numOfQuestions;
        rateText.text = $"正解率：{(rate*100).ToString("F2")}% ";
        correctText.text = $"正解数：{GameManager.numOfCorrects} / {GameManager.numOfQuestions}";
        timerText.text = $"クリアタイム：{GameManager.Timer.ToString("F3")}";

        if (rate < 0.4f)
        {
            resultText.text = "しっかり観察して見よう！\n違いがわかってくるはず！";
        }
        else if (rate < 0.7f)
        {
            resultText.text = "めげずにもう一度挑戦してみよう！";
        }
        else if (rate < 1)
        {
            resultText.text = "おしい！\nここまで来たら全問正解にチャレンジ！";
        }
        else if (rate == 100)
        {
            resultText.text = "すごい！\nこれであなたはプロ「ヘ」ッショナルです！";
        }
    }

    public void OnClickedTitle()
    {
        sceneController.ToTitle();
    }
}
