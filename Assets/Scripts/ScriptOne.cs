using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptOne : MonoBehaviour
{


    [SerializeField]
    private int _MyVar;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(message: "This is Log");
        Debug.LogWarning(message: "This is Warning");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
