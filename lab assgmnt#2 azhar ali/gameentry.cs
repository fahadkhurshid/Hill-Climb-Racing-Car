using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class gameentry : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void start_game()
    {
        SceneManager.LoadScene("gamescene");
    }
    public void exitgame()
    {
        Debug.Log("exitgame");
        Application.Quit();
    }
}
