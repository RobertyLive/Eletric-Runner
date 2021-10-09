using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class ContNumber : MonoBehaviour
{
    public Text cont;
    void Start()
    {
        StartCoroutine(Contador());
    }

    IEnumerator Contador()
    {


        while (true)
        {
            cont.text = 3.ToString();
            yield return new WaitForSeconds(1);
            cont.text = 2.ToString();
            yield return new WaitForSeconds(1);
            cont.text = 1.ToString();
            yield return new WaitForSeconds(1);
            cont.gameObject.SetActive(false);
            Stop();
            SceneManager.LoadScene(2);
        }
    }

    private void Stop()
    {
        StopCoroutine(nameof(Contador));
    }
}
