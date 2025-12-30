using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DialogueTutorial : MonoBehaviour
{
    [Header("Components")]
   // [SerializeField] private GameObject tutorialPanel;

    public GameObject tutorialPanel;
    public Image profile;
    public Image slide;
    public TextMeshProUGUI speechText;
    public TextMeshProUGUI actorNameText;
    private int index;

    [Header("Settings")] 
    public float typingSpeed;
    private string[] sentences;
    private Sprite[] aula;
    private Sprite[] rostos;
    private string[] nomes;


   // [SerializeField] private TextMeshProUGUI dialogueText;

   // private Story currentStory;

    private bool dialogueIsPlaying;

    private static DialogueTutorial instance;


    private void Awake() 
    {
        if (instance != null)
        {
            Debug.LogWarning("Found more than one Dialogue Manager in the scene");
        }
        instance = this;


    }

    public static DialogueTutorial GetInstance() 
    {
        return instance;
    }

    private void Start(){
        dialogueIsPlaying = false;
        tutorialPanel.SetActive(false);



    }

    public void Speech( Sprite[] p, string[] txt, string[] actorName, Sprite[] Slide)
{
        dialogueIsPlaying = true;
        tutorialPanel.SetActive(true);
        rostos = p;
        sentences = txt;
        nomes = actorName;
        aula = Slide; 
        StartCoroutine(TypeSentece());
}

    IEnumerator TypeSentece(){
        profile.sprite = rostos[index];
        actorNameText.text = nomes[index];
        slide.sprite = aula[index]; 

        yield return new WaitForSeconds(0.5f);

        foreach (char letter in sentences[index].ToCharArray()){
            speechText.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
   
    }

    public void NextSentence(){

            //ainda tem textos
            if(index < sentences.Length -1){

                index++;
                speechText.text = "";
                StartCoroutine(TypeSentece());
            }else{// quando acabar
                speechText.text = "";
                index = 0;
                tutorialPanel.SetActive(false);
            }
        
    }


    private void Update(){
        if(!dialogueIsPlaying){
            return;
        }

    }
    public void StopDialogue(){
        speechText.text = "";
        index = 0;
        tutorialPanel.SetActive(false);
   }

    public void ExitDialogueMode(){
    speechText.text = ""; 
    index = 0; 
    tutorialPanel.SetActive(false); 
    }

}