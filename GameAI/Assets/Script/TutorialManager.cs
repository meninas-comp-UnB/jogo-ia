using UnityEngine;
using UnityEngine.UI;

public class TutorialManager : MonoBehaviour
{
    [Header("UI do Tutorial")]
    public GameObject painelTutorial;
    public Image imagemMostrador;    

    [Header("Imagens do Tutorial")]
    public Sprite[] slidesTutorial;   

    private int slideAtual = 0;   

    private void Start()
    {
        if (painelTutorial != null) 
            painelTutorial.SetActive(false);
    }

    public void AbrirTutorial()
    {
        if (slidesTutorial.Length == 0) return; 

        slideAtual = 0; 
        imagemMostrador.sprite = slidesTutorial[slideAtual];
        painelTutorial.SetActive(true);
    }

    public void ProximoSlide() 
    {
        slideAtual++;

        if (slideAtual < slidesTutorial.Length)
        {
            imagemMostrador.sprite = slidesTutorial[slideAtual];
        }
        else
        {
            FecharTutorial();
        }
    }
    public void SlideAnterior()
    {
        slideAtual--;

        if (slideAtual >= 0)
        {
            imagemMostrador.sprite = slidesTutorial[slideAtual];
        }
        else
        {
            FecharTutorial();
        }
    }

    public void FecharTutorial()
    {
        if (painelTutorial != null) 
            painelTutorial.SetActive(false);
    }
}