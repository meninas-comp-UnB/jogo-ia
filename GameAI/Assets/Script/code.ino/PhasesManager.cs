using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PhasesManager : MonoBehaviour
{
    [Header("Components")]
    public Image phase1to2; // Image da UI a ser alterada
    public Image phase2to3;
    public Image phase3to4;
    public Image phase4to5;
    public Image phase5to6;
    public Image phase6to7;
    public Image phase7to8;
    public Image phase8to9;
    public Image phase2;
    public Image phase3;
    public Image phase4;
    public Image phase5;
    public Image phase6;
    public Image phase7;
    public Image phase8;
    public Image phase9;
    public Sprite cabo1;
    public Sprite cabo2;
    public Sprite cabo3;
    public Sprite cabo4;
    public Sprite cabo5;
    public Sprite cabo6;
    public Sprite cabo7;
    public Sprite cabo8;
    public Sprite cabo9;
    public Sprite newPhase2;
    public Sprite newPhase3;
    public Sprite newPhase4;
    public Sprite newPhase5;
    public Sprite newPhase6;
    public Sprite newPhase7;
    public Sprite newPhase8;
    public Sprite newPhase9;
    public Button Botao;

    private void Awake()
    {
        Botao.interactable = false;
        if (PlayerPrefs.GetInt("Phase2", 0) == 1)
        {
            Botao.interactable = true;
            phase1to2.sprite = cabo1;
            phase2.sprite = newPhase2;
        }
        if (PlayerPrefs.GetInt("Phase3", 0) == 1)
        {
            phase2to3.sprite = cabo2;
            phase3.sprite = newPhase3;
        }
        if (PlayerPrefs.GetInt("Phase4", 0) == 1)
        {
            phase3to4.sprite = cabo3;
            phase4.sprite = newPhase4;
        }
        if (PlayerPrefs.GetInt("Phase5", 0) == 1)
        {
            phase4to5.sprite = cabo4;
            phase5.sprite = newPhase5;
        }
        if (PlayerPrefs.GetInt("Phase6", 0) == 1)
        {
            phase5to6.sprite = cabo5;
            phase6.sprite = newPhase6;
        }
        if (PlayerPrefs.GetInt("Phase7", 0) == 1)
        {
            phase6to7.sprite = cabo7;
            phase7.sprite = newPhase7;
        }
        if (PlayerPrefs.GetInt("Phase8", 0) == 1)
        {
            phase7to8.sprite = cabo8;
            phase8.sprite = newPhase8;
        }
        if (PlayerPrefs.GetInt("Phase9", 0) == 1)
        {
            phase8to9.sprite = cabo9;
            phase9.sprite = newPhase9;
        }

    }
    
   void Start () {
    
 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
