using UnityEngine;
using UnityEngine.UI;

public class SliderScript : MonoBehaviour
{
    private Slider slider;

    [SerializeField]
    private Text text;


    // Start is called before the first frame update
    void Start()
    {
        slider = GetComponent<Slider>();
        slider.onValueChanged.AddListener(OnSliderValueChanged);
        slider.value = GameManager.numOfQuestions;
        text.text = $"{GameManager.numOfQuestions} –â";
    }

    void OnSliderValueChanged(float value)
    {
        text.text = $"{value.ToString("F0")} –â";
        GameManager.numOfQuestions = (int)value;
    }
}
