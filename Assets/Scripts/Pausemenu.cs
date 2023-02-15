using UnityEngine;
using UnityEngine.SceneManagement;

public class Pausemenu : MonoBehaviour
{
    private bool isPaused;
    public GameObject PausePanel;
    public GameObject Buttons;
    public string sceneToLoad;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(isPaused) 
                ResumeGame();
            else
                PauseGame();    
        }


        if (Input.GetKeyDown(KeyCode.Space))
        {
            sceneToLoad = "BOSS";
        }

    }

    public void PauseGame()
    {
        Time.timeScale = 0;
        isPaused = true;    
        PausePanel.SetActive(true);

    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
        isPaused= false;
        PausePanel.SetActive(false);    
    }

    public void ExitGame()
    {
        Debug.Log("Quitted");
        Application.Quit();


    } //Every { must have a } to match it

    //We added a string argument to this one, so it can be reused for other scenes
    public void LoadLevel(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
