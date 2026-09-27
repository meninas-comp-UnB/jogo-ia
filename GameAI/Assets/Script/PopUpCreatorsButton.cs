using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))] 
public class PopUpButton : MonoBehaviour
{
    [Header("Content of PopUp")]
    public Sprite creatorPhoto;
    public string creatorName;
    [TextArea(3, 10)] 
    public string creatorDescription;
    public string linkedinUrl;

    private Button myButton;

    private void Start()
    {
        myButton = GetComponent<Button>();
        myButton.onClick.AddListener(OnButtonClick);
    }

    private void OnButtonClick()
    {
        PopUpManager.Instance.OpenPopUp(creatorPhoto, creatorName, creatorDescription, linkedinUrl);
    }
}