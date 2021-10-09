using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public GameObject painel;

    public Text txtLife;


    private void Awake()
    {

        if(instance == null)
        {
            instance = this;
        }
    }

    private void Start()
    {
        painel.SetActive(false);
    }
    public void ShowPainel(bool i)
    {
        painel.SetActive(i);
    }
    public void LoadScene(int i)
    {
        SceneManager.LoadScene(i);
    }
}
