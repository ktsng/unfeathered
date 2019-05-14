using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour
{
    // Start is called before the first frame update
    public void PlayGame()
    {
        SceneManager.LoadScene(3); //tutorial
    }

    // Update is called once per frame
    public void Quit()
    {
        Application.Quit();
    }
}
