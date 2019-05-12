using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Command;
public class SetType : MonoBehaviour, ICommand
{
    [SerializeField] private string m_ID;
    [SerializeField] private string m_Type;
    public string Type {
        get { return m_Type; }
        set { m_Type = value; }
    }
    [SerializeField] private GameObject m_Object;

    public void Execute(Invoker invoker)
    {
        m_ID = invoker.ID;
        m_Type = invoker.Type;
        SetItemType();
    }

    public void SetItemType()
    {
        m_Object = GameObject.Find(m_ID);

        if (m_Object != null)
        {
            m_Object.GetComponent<Item>().Type = m_Type;
        }
    }
}
