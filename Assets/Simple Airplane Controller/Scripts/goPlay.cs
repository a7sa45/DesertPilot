using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class goPlay : MonoBehaviour
{
    public void loadnextlevel()
    {
        SceneManager.LoadScene(0);
    }

    public void intro()
    {
        SceneManager.LoadScene(2);
    }

    public void home()
    {
        SceneManager.LoadScene(3);
    }

    public void close()
    {
        //Application.Quit();
        UnityEditor.EditorApplication.isPlaying = false;
    }
    // private void OnTriggerEnter(collider other)
    // {
    //     SceneManager.LoadScene(0);
    // }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) == true)
        {
            SceneManager.LoadScene(3);
        }
        if(Input.GetKeyDown(KeyCode.O) == true)
        {
            SceneManager.LoadScene(2);
        }
    }
}
