using UnityEngine;
using UnityEngine.SceneManagement;

public class MasterManager : MonoBehaviour
{
    public static MasterManager instance;
    
    public UIManager uiManager;
    public DoorManager doorManager;
    public Pickups pickups;
    public GameObject exitLevel;
    public int spawnedPickups;
    #region CheckIFThereIsExistingManager
    private void Awake()
    {
        if (instance == null) instance = this;
        else Destroy(gameObject);
    }
    

    #endregion


    private void Start()
    {
        spawnedPickups = pickups.pickups.Length;
        exitLevel.SetActive(false);
    }

    public void QuitToMainMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        PlayerController.hasAKey = false;
        uiManager.scoreText.text = "    ";
    }
}
