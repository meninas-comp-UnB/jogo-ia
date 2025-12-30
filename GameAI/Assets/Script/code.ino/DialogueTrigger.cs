using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueTrigger : MonoBehaviour
{
    [Header("Visual Cue")]
    [SerializeField] private GameObject visualCue;
    public bool tutorialVersion;
    public int phase; 

    public bool changeImage; // Flag para indicar se a sprite deve ser alterada

    public Sprite[] profile;
    public Sprite[] slide;
    public string[] speechText;
    public string[] actorNameText;
    private bool playerInRange;
    private bool dialogueIsPlaying; // Flag para indicar se o diálogo está em andamento
     

    private void Awake() 
    {
        playerInRange = false;
        visualCue.SetActive(true);
        dialogueIsPlaying = false; // Inicializa a flag como false
    }

    private void Update() 
    {
        if (playerInRange && !dialogueIsPlaying) // Verifica se o jogador está dentro do gatilho e o diálogo não está em andamento
        {
            visualCue.SetActive(false);
        }
        else 
        {
            visualCue.SetActive(true);
        }
    }

    private void OnTriggerEnter2D(Collider2D collider) 
    {
        if (collider.gameObject.tag == "Player" && !dialogueIsPlaying) // Verifica se o jogador entrou no gatilho e o diálogo não está em andamento
        {
            playerInRange = true;
            if (tutorialVersion == true)
            {
                DialogueTutorial.GetInstance().Speech(profile, speechText, actorNameText, slide);
            }
            else
            {
                // Passa a nova sprite ao chamar o diálogo
                DialogueManager.GetInstance().Speech(profile, speechText, actorNameText, slide, changeImage);
                
            }
            dialogueIsPlaying = true; // Define a flag como true quando o diálogo é iniciado
        }
    }

    private void OnTriggerExit2D(Collider2D collider) 
    {
        if (collider.gameObject.tag == "Player")
        {
            playerInRange = false;
            dialogueIsPlaying = false; // Define a flag como false quando o jogador sai do gatilho
        }
    }
}
