using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FileLoad : MonoBehaviour
{
    public Text  [] textGUI;
    public string[] path;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < path.Length; i++)
        {
            textGUI[i].text = System.IO.File.ReadAllText(path[i]);
        }
    }
}
