using UnityEngine;
using TMPro;

public class FilterManager : MonoBehaviour
{
    [Header("Filter GameObjects")]
    // Drag 'Zappar Full Head Model' here
    [SerializeField] private GameObject facePaintFilter; 
    // Drag your 'helmet' object here
    [SerializeField] private GameObject helmetFilter;    

    [Header("UI Elements")]
    [SerializeField] private TextMeshProUGUI instructionText;

    void Start()
    {
        ShowFacePaint();
    }

    public void ShowFacePaint()
    {
        facePaintFilter.SetActive(true);
        helmetFilter.SetActive(false);
        if(instructionText != null) instructionText.text = "Face Paint Active";
    }

    public void ShowHelmet()
    {
        facePaintFilter.SetActive(false);
        helmetFilter.SetActive(true);
        if(instructionText != null) instructionText.text = "Helmet Filter Active";
    }
}