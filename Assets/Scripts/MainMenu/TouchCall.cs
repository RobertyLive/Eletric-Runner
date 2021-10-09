using UnityEngine.SceneManagement;
using UnityEngine;

public class TouchCall : MonoBehaviour
{
    private void Update()
    {
        ChageCall();
    }
    public void ChageCall()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene(1);
        }


    }
}
