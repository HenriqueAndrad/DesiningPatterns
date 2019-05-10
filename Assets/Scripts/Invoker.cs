using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Invoker : MonoBehaviour
{
    private string m_ID;
    public string ID { get { return m_ID; } }
    private string m_Type;
    public string Type { get { return m_Type; } }

    private string[] m_Strings;
    [SerializeField] private InputField m_InputField;


    private void Update()
    {
       m_Strings = m_InputField.text.Split(' ');
    }
}
