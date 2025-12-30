using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class TutorialManager : MonoBehaviour
{
    [Header("Components")]
   // [SerializeField] private GameObject dialoguePanel;

    public GameObject tutorialPanel;
    public Image examples;
    
    

    [Header("Settings")] 
    public Sprite[] ex;

    private bool playerInRange;
   

   // [SerializeField] private TextMeshProUGUI dialogueText;

    //private Story currentStory;
    private Sprite[] telas;

    private bool dialogueIsPlaying;

    private static TutorialManager instance;
    public int index;


    private void Awake() 
    {
        if (instance != null)
        {
            Debug.LogWarning("it is not working");
        }
        instance = this;


    }

    public static TutorialManager GetInstance() 
    {
        return instance;
    }

    private void Start(){
        dialogueIsPlaying = false;
        tutorialPanel.SetActive(false);

    }

    public void Speech( Sprite[] e)
{
        dialogueIsPlaying = true;
        tutorialPanel.SetActive(true);
        telas = e; 
        examples.GetComponent<Image>().sprite = telas[0];
}


    public void NextSentence(){
        if(index < 6){
            examples.GetComponent<Image>().sprite = telas[index];
            index++;
        }else{// quando acabar

                index = 1;
                tutorialPanel.SetActive(false);
            }
    
    }

    private void Update(){
        if(!dialogueIsPlaying){
            return;
        }

    }

//    public void ExitDialogueMode(){
       // dialogueIsPlaying = false;
       // dialoguePanel.SetActive(false);
 //   }

    
    public void buttom() 
    {
  
      //  playerInRange = true;
        TutorialManager.GetInstance().Speech(ex);

    }

}