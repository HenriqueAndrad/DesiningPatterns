using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Command
{
    public class SetType : MonoBehaviour, ICommand
    {
        [SerializeField] private string m_ID;
        [SerializeField] private string m_Type;
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
            m_Object.GetComponent<Item>().m_Type = m_Type;
        }
    }
}