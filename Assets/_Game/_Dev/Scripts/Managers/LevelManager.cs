using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public static LevelManager instance = null;

    [SerializeField] Level[] levels;
    [SerializeField] Transform levelSpawner;
    [SerializeField] bool isTesting;
    public Level currentLv;

    int levelNumberUI, lastLevelPlayed;


    #region GET & SET
    public int LastLevelPlayed
    {
        get { return lastLevelPlayed; }
        set { lastLevelPlayed = value; }
    }

    public int LevelNumberUI
    {
        get { return levelNumberUI; }
        set { levelNumberUI = value; }
    }

    #endregion

    #region EVENTS
    public delegate void OnRestartedLevel();
    public static OnRestartedLevel onRestartedLevel;

    #endregion

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        lastLevelPlayed = PlayerPrefs.HasKey("last_level") ? PlayerPrefs.GetInt("last_level") : 0;
        levelNumberUI = PlayerPrefs.HasKey("level_number_UI") ? PlayerPrefs.GetInt("level_number_UI") : 0;

        if (isTesting) return;
        SpawnLevel();

    }

    void SpawnLevel()
    {
        currentLv = Instantiate(levels[lastLevelPlayed], levelSpawner);
        //splineManager.SetCurrentSpline();
    }

    public void RestartLevel()
    {
        onRestartedLevel?.Invoke();
    }

    public void RestartScene()
    {
        SceneManager.LoadScene(0);
        // #if UNITY_EDITOR
        //         SceneManager.LoadScene(1, LoadSceneMode.Additive);
        // #endif
    }


    public void SetNextLevel()
    {
        lastLevelPlayed++;
        if (lastLevelPlayed >= levels.Length)
        {
            lastLevelPlayed = 0;
        }
        PlayerPrefs.SetInt("last_level", lastLevelPlayed);
        RestartScene();
        //onRestartedLevel?.Invoke();

    }
}