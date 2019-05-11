using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Command;

public class DestroyCommand : MonoBehaviour, ICommand
{
    [SerializeField] private string m_ID;
    [SerializeField] private string m_Type;
    [SerializeField] private GameObject m_Object;

    public void Execute(Invoker invoker)
    {
        m_ID = invoker.ID;
        m_Type = invoker.Type;
        DestroyItem();
    }

    public void DestroyItem()
    {
        m_Object = GameObject.Find(m_ID);

        if (m_Object != null)
        {
            Destroy(m_Object);
        }
    }
}
