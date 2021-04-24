using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuLog : MonoBehaviour
{
    public void ExitButton()
    {
        Application.Quit();
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void Instagram()
    {
        Application.OpenURL("https://www.instagram.com/iota_acid/");
    }

    public void GitHub()
    {
        Application.OpenURL("https://github.com/IotA-asce");
    }

    public void Rahul()
    {
        Application.OpenURL("https://instagram.com/_rahul_manna?igshid=lzetc2824ke6");
    }

    public void Satabda()
    {
        Application.OpenURL("https://instagram.com/edward_ed_0207?igshid=z3tf5fm0nd4t");
    }
    
    public void Suvo()
    {
        Application.OpenURL("https://instagram.com/suvo_khan6347?igshid=3ksuhapv8auq");
    }
}
