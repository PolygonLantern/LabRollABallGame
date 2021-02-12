using UnityEngine;

public class ExitGameTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            SoundManager.instance.Play("LevelCleared");
            CalculateScoreResults();
            MasterManager.instance.uiManager.victoryPanel.SetActive(true);
        }
    }


    void CalculateScoreResults()
    {
        var text = MasterManager.instance.uiManager.victoryPanelScoreText;
        if (ScoreManager.pickupScore == MasterManager.instance.spawnedPickups)
        {
            text.text = "Congratulations, you collected all the points! Score: " + ScoreManager.pickupScore;
        }
        else
        {
            text.text = "Score: " + ScoreManager.pickupScore;
        }
    }
}
