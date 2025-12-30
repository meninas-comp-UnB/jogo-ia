using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class ConfigManager : MonoBehaviour
{

   // [SerializeField] private GameObject dialoguePanel;
    public string cena;

    public GameObject configPanel;


    private bool dialogueIsPlaying;

    private static ConfigManager  instance;

    private void Awake() 
    {
        if (instance != null)
        {
            Debug.LogWarning("it is not working");
        }
        instance = this;


    }

    public static ConfigManager GetInstance() 
    {
        return instance;
    }

    private void Start(){
        dialogueIsPlaying = false;
        configPanel.SetActive(false);

    }

    public void Speech()
{
        dialogueIsPlaying = true;
        configPanel.SetActive(true);
}


    private void Update(){
        if(!dialogueIsPlaying){
            return;
        }

    }

    
    public void buttom() 
    {
  
        ConfigManager.GetInstance().Speech();

    }

    public void changeScene(){
        SceneManager.LoadScene(cena);
    }

        public void QuitGame()
    {
        //Unity
      //  UnityEditor.EditorApplication.isPlaying = false;
        //Demo
       Application.Quit();

    }

    public void QuitScene()
    {

        configPanel.SetActive(false);


    }
}
