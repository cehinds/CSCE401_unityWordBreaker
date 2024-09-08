using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cst_keyboardTest_script : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        cs_keyboard_script.onKeyPressed += debugLetter;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void debugLetter(char key)
    {
        Debug.Log(key);
    }
}
