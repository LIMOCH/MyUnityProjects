using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;

public class Timer : MonoBehaviour
{
    public float sec = 60.0f;
    public int min = 1;
    void Update()
    {
        sec -= Time.deltaTime;
        if (sec <= 0.0f)
        {
            if(min > 0)
            {
                min -= 1;
                sec += 60;
            }
        }
        print(min + " " + sec);
        if(min == 0 && sec == 0)
        {
            EditorSceneManager.LoadScene("SampleScene");
        }
    }
}
