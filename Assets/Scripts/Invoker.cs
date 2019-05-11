using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Command;

public class Invoker : MonoBehaviour
{
    private string m_ID;
    public string ID { get { return m_ID; } }
    private string m_Type;
    public string Type { get { return m_Type; } }

    [SerializeField] private string[] m_Types;

    private string[] m_Strings;

    private bool m_IsCommand;
    private bool m_IsTranformCommand;
    private bool m_IsDestroyCommand;

    [SerializeField] private InputField m_InputField;
    private string m_Command;

    private SetType m_SetType;
    private DestroyCommand m_DestroyCommand;

    private void Awake()
    {
        m_SetType = new SetType();
        m_DestroyCommand = new DestroyCommand();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return) && m_InputField.text != null)
        {
            ReadCommand();

            if (m_IsCommand)
            {
                m_ID = m_Strings[1];
                m_Type = m_Strings[0];
                if (m_IsTranformCommand)
                {
                    m_SetType.Execute(this.GetComponent<Invoker>());
                }
                if (m_IsDestroyCommand)
                {
                    m_DestroyCommand.Execute(this.GetComponent<Invoker>());
                }
            }
        }
    }

    private void ReadCommand()
    {
        m_Command = m_InputField.text;
        m_InputField.text = null;
        m_Strings = m_Command.Split(' ');
        m_IsCommand = CheckIfIsCommand();
    }

    private bool CheckIfIsCommand()
    {
        if (m_Strings.Length == 2 )
        {
            if (m_Strings[0] == "/mage" || m_Strings[0] == "/warrior" || m_Strings[0] == "/thief")
            {
                m_IsTranformCommand = true;
                m_IsDestroyCommand = false;
                return true;
            }else if(m_Strings[0] == "/destroy")
            {
                m_IsTranformCommand = false;
                m_IsDestroyCommand = true;
                return true;
            }

            return false;
        }

        return false;
    }
}
