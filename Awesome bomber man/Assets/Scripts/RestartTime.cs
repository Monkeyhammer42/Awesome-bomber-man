using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartTime : MonoBehaviour
{
    public void RestartGame() {
        SceneManager.LoadScene("Gameplay");
        Time.timeScale = 1f;
        }
    void start() { }
    void Update()
    {

    }


}
