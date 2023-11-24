using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject homeCamera;
    public GameObject homePage;

    public GameObject creditsCamera;
    public GameObject creditsPage;

    public GameObject dj;

    public void StartGame() {
        SceneManager.LoadScene("RadwanScene");
    }

    public void Credits() {
        creditsCamera.SetActive(true);
        dj.SetActive(true);
        homeCamera.SetActive(false);

        creditsPage.SetActive(true);
        homePage.SetActive(false);
    }

    public void BackFromCredits() {
        creditsCamera.SetActive(false);
        dj.SetActive(false);
        homeCamera.SetActive(true);

        creditsPage.SetActive(false);
        homePage.SetActive(true);
    }

    public void Quit() {
        Application.Quit();
    }
}
