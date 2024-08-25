using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject _startMenu;
    [SerializeField] TextMeshProUGUI _levelText;
    [SerializeField] GameObject _endWindow;
    [SerializeField] CoinStatistics _coinStatistics;

    private void Start()
    {
        _levelText.text = SceneManager.GetActiveScene().name;
    }
    public void Play()
    {
        _startMenu.SetActive(false);
        FindObjectOfType<PlayerBehaviour>().Play();
    }
    public void ShowEndWindow()
    {
        _endWindow.SetActive(true);
    }
    public void NextLvl()
    {
        int next = SceneManager.GetActiveScene().buildIndex + 1;
        if (next < SceneManager.sceneCountInBuildSettings)
        {
            _coinStatistics.SaveToProgress();
            SceneManager.LoadScene(next);
        }
    }
}
