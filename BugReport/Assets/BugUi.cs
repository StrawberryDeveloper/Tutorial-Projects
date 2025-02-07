using System;
using TMPro;
using UnityEngine;

public class BugUi : MonoBehaviour
{

    public GameObject FormHolder;
    public TMP_InputField InputField;

    private void Start()
    {
        FormHolder.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F5))
        {
            FormHolder.SetActive(!FormHolder.activeSelf);
        }
    }

    public void Submit()
    {
        //Debug.Log(InputField.text);
        BugReporting.Send(InputField.text);
    }
}
