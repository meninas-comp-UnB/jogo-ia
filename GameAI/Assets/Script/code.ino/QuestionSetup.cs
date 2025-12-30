using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class QuestionSetup : MonoBehaviour
{
    [SerializeField] private List<QuestionData> questions;
    private List<QuestionData> originalQuestions;
    private QuestionData currentQuestion;
    public bool tutorial_version;
    public string numberPhase;

    [SerializeField] private TextMeshProUGUI questionText;
    [SerializeField] private AnswerButton[] answerButtons;
    [SerializeField] private TextMeshProUGUI pointsText;
    [SerializeField] private GameObject resultPanel;
    [SerializeField] private TextMeshProUGUI resultText;
    [SerializeField] private Image resultImage;
    [SerializeField] private Button playAgainButton;
    [SerializeField] private Button backButton;

    [SerializeField] private Sprite spriteForPass; // Atribua no Unity
    [SerializeField] private Sprite spriteForFail; // Atribua no Unity
    [SerializeField] private Image finalImage;

    private int index = 1;
    private bool hasAnswered = false;
    private int correctAnswersCount = 0;

    private void Awake()
    {
        GetQuestionAssets();
    }

    void Start()
    {
        SetNextQuestion();
    }

    public void NextSentence()
    {
        if (!hasAnswered && index <= 5)
        {
            hasAnswered = true;
            SetNextQuestion();
        }
        else if (index > 5)
        {
            ShowResultPanel();
        }
    }

    private void GetQuestionAssets()
    {
        originalQuestions = new List<QuestionData>(Resources.LoadAll<QuestionData>(numberPhase));
        questions = new List<QuestionData>(originalQuestions);
    }

    private void SetNextQuestion()
    {
        SelectNewQuestion();
        SetQuestionValues();
        SetAnswerValues();
        SetPoint(index);
        index++;
        ResetButtonsInteractivity();
        hasAnswered = false;
    }

    private void SelectNewQuestion()
    {
        if (questions.Count == 0)
        {
            questions = new List<QuestionData>(originalQuestions);
        }

        int randomQuestionIndex = Random.Range(0, questions.Count);
        currentQuestion = questions[randomQuestionIndex];
        questions.RemoveAt(randomQuestionIndex);
    }

    private void SetQuestionValues()
    {
        questionText.text = currentQuestion.question;
    }

    private void SetAnswerValues()
    {
        for (int i = 0; i < answerButtons.Length; i++)
        {
            if (i < currentQuestion.answers.Length)
            {
                answerButtons[i].Initialize(currentQuestion.answers[i], currentQuestion.images[i], i == currentQuestion.correctAnswer);
            }
            else
            {
                answerButtons[i].gameObject.SetActive(false);
            }
        }
    }

    private void SetPoint(int number)
    {
        pointsText.text = $"{number}/5";
    }

    private void ResetButtonsInteractivity()
    {
        foreach (var button in answerButtons)
        {
            button.ResetButtonAppearance();
        }
    }

    public void RegisterAnswer(bool isCorrect)
    {
        if (isCorrect)
        {
            correctAnswersCount++;
        }
    }

    private void ShowResultPanel()
    {
        if (correctAnswersCount >= 3)
        {
            resultText.text = $"Parabéns pela conquista! Você acertou {correctAnswersCount} de 5 perguntas!";
            finalImage.sprite = spriteForPass;
            if (numberPhase == "Fase1")
            {
                PlayerPrefs.SetInt("PracticeImage", 1); 
                PlayerPrefs.SetInt("Phase2", 1);
            }
            else if (numberPhase == "Fase2")
            {
                PlayerPrefs.SetInt("PracticeImage2", 1); 
                PlayerPrefs.SetInt("Phase3", 1);
            }
            else if (numberPhase == "Fase3")
            {
                PlayerPrefs.SetInt("PracticeImage3", 1); 
                PlayerPrefs.SetInt("Phase4", 1);
            }
            else if (numberPhase == "Fase4")
            {
                PlayerPrefs.SetInt("PracticeImage4", 1);
                PlayerPrefs.SetInt("Phase5", 1); 
            }
            else if (numberPhase == "Fase5")
            {
                PlayerPrefs.SetInt("PracticeImage5", 1); 
                PlayerPrefs.SetInt("Phase6", 1);
            }
            else if (numberPhase == "Fase6")
            {
                PlayerPrefs.SetInt("PracticeImage6", 1);
                PlayerPrefs.SetInt("Phase7", 1); 
            }
            else if (numberPhase == "Fase7")
            {
                PlayerPrefs.SetInt("PracticeImage7", 1); 
                PlayerPrefs.SetInt("Phase8", 1);
            }
            else if (numberPhase == "Fase8")
            {
                PlayerPrefs.SetInt("PracticeImage8", 1); 
                PlayerPrefs.SetInt("Phase9", 1);
            }


            PlayerPrefs.Save();
        }
        else
        {
            resultText.text = $"Você acertou {correctAnswersCount} de 5 perguntas. Melhore na próxima vez!";
            finalImage.sprite = spriteForFail;
        }
    
        resultPanel.SetActive(true);
        playAgainButton.gameObject.SetActive(true);
        backButton.gameObject.SetActive(true);
    }

    public void PlayAgain()
    {
        resultPanel.SetActive(false);
        index = 1; 
        correctAnswersCount = 0;
        hasAnswered = false; 
        questions = new List<QuestionData>(originalQuestions); 
        SetNextQuestion();

    }

    public void GoBack()
    {
        if (numberPhase == "Fase1")
        {
            SceneManager.LoadScene("Fase-1");
        }
        else if (numberPhase == "Fase2")
        {
            SceneManager.LoadScene("Fase-2");
        }
        else if (numberPhase == "Fase3")
        {
            SceneManager.LoadScene("Fase-3");
        }
        else if (numberPhase == "Fase4")
        {
            SceneManager.LoadScene("Fase-4");
        }
        else if (numberPhase == "Fase5")
        {
            SceneManager.LoadScene("Fase-5");
        }
        else if (numberPhase == "Fase6")
        {
            SceneManager.LoadScene("Fase-6");
        }
        else if (numberPhase == "Fase7")
        {
            SceneManager.LoadScene("Fase-7");
        }
        else if (numberPhase == "Fase8")
        {
            SceneManager.LoadScene("Fase-8");
        }
        else if (numberPhase == "Fase9"){
            SceneManager.LoadScene("Fase-9");
        }
    }
}