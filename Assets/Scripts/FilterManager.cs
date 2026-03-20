using UnityEngine;
using TMPro;

public class FilterManager : MonoBehaviour
{
    [SerializeField] private GameObject startPanel;
    [SerializeField] private GameObject facePaintFilter; 
    [SerializeField] private GameObject helmetFilter;    
    [SerializeField] private TextMeshProUGUI instructionText;
    private bool showHelmet = false;

    void Start()
    {
        facePaintFilter.SetActive(false);
        helmetFilter.SetActive(false);
        startPanel.SetActive(true);
    }

    public void StartExperience()
    {
        startPanel.SetActive(false);
        ShowFacePaint(); 
    }

    public void ShowFacePaint()
    {
        showHelmet = false;
        facePaintFilter.SetActive(true);
        helmetFilter.SetActive(false);
        instructionText.text = "Face Paint Active";
    }

    public void ShowHelmet()
    {
        showHelmet = true;
        facePaintFilter.SetActive(false);
        helmetFilter.SetActive(true);
        instructionText.text = "Helmet Active";
    }

    public void HideHelmetOnFaceUnseen() {
        helmetFilter.SetActive(false);
    }

    public void ShowHelmetOnFaceSeen() {
        if(!showHelmet) return;
        ShowHelmet();
    }
}