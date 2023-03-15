using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;

public class dead : MonoBehaviour
{
    public string sceneName;
    void OnTriggerEnter(Collider other)
    {
        EditorSceneManager.LoadScene("SampleScene");
    }
}
