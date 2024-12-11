using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScript : MonoBehaviour
{
    public string firstSceneName = "";
    void Start()
    {
        SceneManager.LoadScene(firstSceneName);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
