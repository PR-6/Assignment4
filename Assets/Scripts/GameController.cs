using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class GameController : MonoBehaviour
{
    //PlayerName:
    public InputField playerName;

    //Lives DropDown:
    List<string> playerLives = new List<string>() { "3", "4", "5" };
    public Dropdown dropdown;

    // Standard Functions:
    private void Awake()
    {
        PlayerPrefs.DeleteAll();
        PopulateList();
    }

    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    void Start()
    {
        
    }

    // PlayerName Logic:
    public void setPlayerName()
    {
        Debug.Log(playerName.text);
        PlayerPrefs.SetString("PlayerName", playerName.text);
    }

    //Dropdown lives Logic:
    public void DropDownIndexChanged(int index)
    {
        Debug.Log("Lives = " + playerLives[index]);
        PlayerPrefs.SetInt("LivesRemaining", int.Parse(playerLives[index]));
    }

    void PopulateList()
    {
        dropdown.AddOptions(playerLives);
    }
}