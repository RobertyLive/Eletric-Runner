using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlAlpha : MonoBehaviour
{
    public bool breakWhile = true;
    void Start()
    {
        Camera.main.orthographicSize = 1f;
        StartCoroutine(VisionCamera());
    }
    private void Update()
    {
        if (!breakWhile)
        {
            StopCoroutine(nameof(VisionCamera));
        }
    }

    IEnumerator VisionCamera()
    {
        Camera.main.orthographicSize = 2f;
        yield return new WaitForSeconds(0.5f);
        Camera.main.orthographicSize = 3f;
        yield return new WaitForSeconds(0.5f);
        Camera.main.orthographicSize = 4f;
        yield return new WaitForSeconds(0.5f);
        Camera.main.orthographicSize = 5f;
        yield return new WaitForSeconds(0.5f);
        Camera.main.orthographicSize = 6f;
        yield return new WaitForSeconds(0.5f);
        
    }

}
