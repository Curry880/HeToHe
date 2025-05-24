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
        rateText.text = $"���𗦁F{(rate*100).ToString("F2")}% ";
        correctText.text = $"���𐔁F{GameManager.numOfCorrects} / {GameManager.numOfQuestions}";
        timerText.text = $"�N���A�^�C���F{GameManager.Timer.ToString("F3")}";

        if (rate < 0.4f)
        {
            resultText.text = "��������ώ@���Č��悤�I\n�Ⴂ���킩���Ă���͂��I";
        }
        else if (rate < 0.7f)
        {
            resultText.text = "�߂����ɂ�����x���킵�Ă݂悤�I";
        }
        else if (rate < 1)
        {
            resultText.text = "�������I\n�����܂ŗ�����S�␳���Ƀ`�������W�I";
        }
        else if (rate == 100)
        {
            resultText.text = "�������I\n����ł��Ȃ��̓v���u�w�v�b�V���i���ł��I";
        }
    }

    public void OnClickedTitle()
    {
        sceneController.ToTitle();
    }
}
