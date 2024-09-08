using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class cs_keyboard_script : MonoBehaviour
{
    [Header(" Elements ")]
    [SerializeField] private TextMeshProUGUI keyText;

    [Header("Events")]
    public static Action<char> onKeyPressed;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Button>().onClick.AddListener(sendKeyPressedEvent);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void sendKeyPressedEvent()
    {
        onKeyPressed?.Invoke(keyText.text[0]);

    }
}
