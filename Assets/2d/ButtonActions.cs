using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonActions : MonoBehaviour
{
    public GameObject home, tour, feedback, submitting_feedback;

    IEnumerator loadSceneAfterDelay(float waitbySecs){
        yield return new WaitForSeconds(waitbySecs);
    } 

    // Start is called before the first frame update
    void Start()
    {
        this.goToHome();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)) {
            if (tour.activeSelf || feedback.activeSelf || submitting_feedback.activeSelf)
                this.goToHome();
            if (home.activeSelf)
                Application.Quit();
        }
    }

    public void goToHome() {
        home.SetActive(true);
        tour.SetActive(false);
        feedback.SetActive(false);
        submitting_feedback.SetActive(false);
    }

    public void goToTour() {
        home.SetActive(false);
        tour.SetActive(true);
        feedback.SetActive(false);
        submitting_feedback.SetActive(false);
    }

    public void goToFeedback() {
        home.SetActive(false);
        tour.SetActive(false);
        feedback.SetActive(true);
        submitting_feedback.SetActive(false);
    }

    public void goToSubmittingFeedback() {
        home.SetActive(false);
        tour.SetActive(false);
        feedback.SetActive(false);
        submitting_feedback.SetActive(true);
    }

    public void goToRealTour() {
      SceneManager.LoadScene("Init");
    }
}
