using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TMP_Text scoreText;
    public int counter = 0;

    void Start()
    {
        LoadGame();
        UpdateUIValues();
    }

    public void SaveGame()
    {
        PlayerPrefs.SetInt(KeysToSave.CounterKey, counter);
        PlayerPrefs.Save();

        Debug.Log("Counter value saved: " + counter);
    }

    public void LoadGame()
    {
        counter = PlayerPrefs.GetInt(KeysToSave.CounterKey, 0);

        Debug.Log("Counter value loaded: " + counter);
    }

    public void IncrementCounter()
    {
        counter++;
        UpdateUIValues();
    }

    void UpdateUIValues()
    {
        scoreText.text = counter.ToString();
    }
}
