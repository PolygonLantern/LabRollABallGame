using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public TMP_Text scoreText;
    public TMP_Text congratsText;
    public TMP_Text victoryPanelScoreText;
    public GameObject victoryPanel;

    private void Start()
    {   
        victoryPanel.SetActive(false);
        congratsText.gameObject.SetActive(false);
        UpdateUI();
    }
    
    
    public void UpdateUI()
    {
        scoreText.text = "Score " + ScoreManager.pickupScore;
    }
    
}
