using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class AnswerButton : MonoBehaviour
{

    private bool isCorrect;
    private bool hasBeenClicked = false;
    [SerializeField] private TextMeshProUGUI answerText;
    [SerializeField] private Image answerImage;
    private Image buttonImage;
    private QuestionSetup questionSetup;

    private Color originalColor;

    public void Initialize(string answerText, Sprite answerImage, bool isCorrect)
    {
        this.isCorrect = isCorrect;
        SetAnswerText(answerText);
        SetAnswerImage(answerImage);
    }

    public void SetAnswerImage(Sprite newSprite)
    {
        answerImage.sprite = newSprite;
    }

    public void SetAnswerText(string newText)
    {
        answerText.text = newText;
    }

    public void ResetButtonAppearance()
    {
        hasBeenClicked = false;
        buttonImage.color = originalColor;
        GetComponent<Button>().interactable = true;
    }

public void OnClick()
{
    if ( !hasBeenClicked)
    {
        hasBeenClicked = true;
        if (isCorrect)
        {
            Debug.Log("CORRECT ANSWER");
            ChangeButtonColor(new Color(0.0f, 0.5f, 0.0f)); // Verde mais escuro
        }
        else
        {
            Debug.Log("WRONG ANSWER");
            ChangeButtonColor(Color.red);
        }

        questionSetup.RegisterAnswer(isCorrect);
        DisableOtherButtons();
    }
}


    // Método para definir a cor para todos os botões
    private void SetColorForAllButtons(Color color)
    {
        AnswerButton[] allButtons = FindObjectsOfType<AnswerButton>();

        foreach (AnswerButton button in allButtons)
        {
            button.ChangeButtonColor(color);
        }
    }

    private void Awake()
    {
        buttonImage = GetComponent<Image>();
        originalColor = buttonImage.color;
        questionSetup = FindObjectOfType<QuestionSetup>();
    }

    private void ChangeButtonColor(Color newColor)
    {
        buttonImage.color = newColor;
    }

    private void DisableOtherButtons()
    {
        AnswerButton[] allButtons = FindObjectsOfType<AnswerButton>();

        foreach (AnswerButton button in allButtons)
        {
            if (button != this)
            {
                button.GetComponent<Button>().interactable = false;
            }
        }
    }
}
