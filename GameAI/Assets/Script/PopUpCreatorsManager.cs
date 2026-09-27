using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PopUpManager : MonoBehaviour
{
    public static PopUpManager Instance;

    [Header("Pop-up UI Elements")]
    public GameObject popUpPanel;
    public Image creatorPhoto;
    public TextMeshProUGUI creatorName;
    public TextMeshProUGUI creatorDescription;

    [Header("New Link Button Elements")]
    public Button linkedinButton;

    private string linkedinUrl;

    private void Awake()
    {
        if (Instance == null) Instance = this;
        popUpPanel.SetActive(false);

        if (linkedinButton != null)
        {
            linkedinButton.onClick.AddListener(OpenExternalLink);
        }
    }

    public void OpenPopUp(Sprite newImage, string newTitle, string newContent, string newUrl)
    {
        creatorPhoto.sprite = newImage;
        creatorName.text = newTitle;
        creatorDescription.text = newContent;
        linkedinUrl = newUrl;

        if (linkedinButton != null)
        {
            linkedinButton.gameObject.SetActive(!string.IsNullOrEmpty(linkedinUrl));
        }

        popUpPanel.SetActive(true);
    }

    public void ClosePopUp()
    {
        popUpPanel.SetActive(false);
    }

    private void OpenExternalLink()
    {
        if (!string.IsNullOrEmpty(linkedinUrl))
        {
            Application.OpenURL(linkedinUrl);
        }
    }
}