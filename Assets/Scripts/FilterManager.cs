using System.Net.Mime;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections;

public class FilterManager : MonoBehaviour
{
    [SerializeField] private GameObject startPanel;
    [SerializeField] private GameObject facePaintFilter; 
    [SerializeField] private GameObject helmetFilter;    
    [SerializeField] private TextMeshProUGUI instructionText;
    private bool showHelmet = false;
    private bool appStart = false;

   void Start()
    {
        StartCoroutine(DelayedStart());
    }

    IEnumerator DelayedStart()
    {
        yield return new WaitForSeconds(0.5f);
        startPanel.SetActive(true);
        facePaintFilter.SetActive(false);
        helmetFilter.SetActive(false);
    }

    public void StartExperience()
    {
        appStart = true;
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

    public void ShowFilterOnFaceSeen() {
        if(!appStart) return;
        if(showHelmet)
            ShowHelmet();
        else
            ShowFacePaint();
    }
}