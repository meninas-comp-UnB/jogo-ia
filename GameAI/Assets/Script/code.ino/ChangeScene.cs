using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void ChangeToScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void ChangeToPhase1()
    {
        ChangeToScene("Fase-1");
    }

    public void ChangeToPhase_2()
    {
        ChangeToScene("Fase-2");
    }

    public void ChangeToPhase_3()
    {
        ChangeToScene("Fase-3");
    }

    public void ChangeToPhase_4()
    {
        ChangeToScene("Fase-4");
    }

    public void ChangeToPhase_5()
    {
        ChangeToScene("Fase-5");
    }

    public void ChangeToPhase_6()
    {
        ChangeToScene("Fase-6");
    }

    public void ChangeToPhase_7()
    {
        ChangeToScene("Fase-7");
    }

    public void ChangeToPhase_8()
    {
        ChangeToScene("Fase-8");
    }

    public void ChangeToPhase_9()
    {
        ChangeToScene("Fase-9");
    }


    public void ChangeToPhase2()
    {
        if (PlayerPrefs.GetInt("Phase2", 0) == 1)
        {
            ChangeToScene("Fase-2");
        }

    }

    public void ChangeToPhase3()
    {
        if (PlayerPrefs.GetInt("Phase3", 0) == 1)
        {
            ChangeToScene("Fase-3");
        }

    }

    public void ChangeToPhase4()
    {
        if (PlayerPrefs.GetInt("Phase4", 0) == 1)
        {
            ChangeToScene("Fase-4");
        }

    }

    public void ChangeToPhase5()
    {
        if (PlayerPrefs.GetInt("Phase5", 0) == 1)
        {
            ChangeToScene("Fase-5");
        }

    }

    public void ChangeToPhase6()
    {
        if (PlayerPrefs.GetInt("Phase6", 0) == 1)
        {
            ChangeToScene("Fase-6");
        }

    }

    public void ChangeToPhase7()
    {
        if (PlayerPrefs.GetInt("Phase7", 0) == 1)
        {
            ChangeToScene("Fase-7");
        }

    }

    public void ChangeToPhase8()
    {
        if (PlayerPrefs.GetInt("Phase8", 0) == 1)
        {
            ChangeToScene("Fase-8");
        }

    }

    public void ChangeToPhase9()
    {
        if (PlayerPrefs.GetInt("Phase9", 0) == 1)
        {
            ChangeToScene("Fase-9");
        }

    }

    public void ChangeToPhasesMenu()
    {
        ChangeToScene("Tela-Fases");
    }
    public void ChangeToQuiz1()
    {
        ChangeToScene("Mini-Game1");
    }
    public void ChangeToQuiz2()
    {
        ChangeToScene("Mini-Game2");
    }

    public void ChangeToQuiz3()
    {
        ChangeToScene("Mini-Game3");
    }

    public void ChangeToQuiz4()
    {
        ChangeToScene("Mini-Game4");
    }

    public void ChangeToQuiz5()
    {
        ChangeToScene("Mini-Game5");
    }

    public void ChangeToQuiz6()
    {
        ChangeToScene("Mini-Game6");
    }

    public void ChangeToQuiz7()
    {
        ChangeToScene("Mini-Game7");
    }

    public void ChangeToQuiz8()
    {
        ChangeToScene("Mini-Game8");
    }
    
    public void ChangeToQuiz9()
    {
        ChangeToScene("Mini-Game9");
    }

}