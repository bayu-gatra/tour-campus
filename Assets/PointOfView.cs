using UnityEngine;
using UnityEngine.SceneManagement;

public class PointOfView : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)) {
            Destroy(this.gameObject);
        }
    }

    void OnDestroy()
    {
        SceneManager.LoadScene("final");
    }
}
