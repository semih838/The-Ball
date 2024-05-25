using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    public Button exitButton;
    public Button button1;
    public Button button2;
    public Button button3;
    public Button button4;
    public Button button5;
    public Button button6;
    public Button button7;
    public Button button8;
    public Button button9;
    public Button button10;
    public Button button11;

    // Use this for initialization
    void Start()
    {
        InitButton();
    }

    private void InitButton()
    {
        exitButton.onClick.AddListener(Shutdown);
        button1.onClick.AddListener(LoadLevel1);
        button2.onClick.AddListener(LoadLevel2);
        button3.onClick.AddListener(LoadLevel3);
        button4.onClick.AddListener(LoadLevel4);
        button5.onClick.AddListener(LoadLevel5);
        button6.onClick.AddListener(LoadLevel6);
        button7.onClick.AddListener(LoadLevel7);
        button8.onClick.AddListener(LoadLevel8);
        button9.onClick.AddListener(LoadLevel9);
        button10.onClick.AddListener(LoadLevel10);
        button11.onClick.AddListener(LoadLevel11);
    }

    private void Shutdown()
    {
        Application.Quit();
    }

    private void LoadLevel1()
    {
        SceneManager.LoadScene("Level 1");
    }
    private void LoadLevel2()
    {
        SceneManager.LoadScene("Level 2");
    }

    private void LoadLevel3()
    {
        SceneManager.LoadScene("Level 3");
    }

    private void LoadLevel4()
    {
        SceneManager.LoadScene("Level 4");
    }

    private void LoadLevel5()
    {
        SceneManager.LoadScene("Level 5");
    }

    private void LoadLevel6()
    {
        SceneManager.LoadScene("Level 6");
    }

    private void LoadLevel7()
    {
        SceneManager.LoadScene("Level 7");
    }

    private void LoadLevel8()
    {
        SceneManager.LoadScene("Level 8");
    }

    private void LoadLevel9()
    {
        SceneManager.LoadScene("Level 9");
    }

    private void LoadLevel10()
    {
        SceneManager.LoadScene("Level 10");
    }

    private void LoadLevel11()
    {
        SceneManager.LoadScene("Level 11");
    }
}
