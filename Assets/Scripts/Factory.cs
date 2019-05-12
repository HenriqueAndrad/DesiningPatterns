using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Factory
{
    public class Factory : MonoBehaviour
    {
        [SerializeField] GameObject m_Armor;
        [SerializeField] GameObject m_Helmet;
        [SerializeField] GameObject m_Weapon;
        [SerializeField] Canvas m_Canvas;

        private int m_ID;

        Vector3 m_SpawnPosition;

        void SetSpawnPosition()            
        {
            m_SpawnPosition.x = Random.Range(100.0f, Screen.width - 100);
            m_SpawnPosition.y = Random.Range(200.0f, Screen.height - 200);
            m_SpawnPosition.z = 0.0f;
            Debug.Log(Screen.height);
        }

        public void CreateGenericArmor()
        {
            SetSpawnPosition();
            GameObject temp = Instantiate(m_Armor, m_SpawnPosition, Quaternion.identity);
            temp.GetComponent<Armor>().gameObject.name = m_ID.ToString();
            ++m_ID;
        }

        public void CreateGenericHelmet()
        {
            SetSpawnPosition();
            GameObject temp = Instantiate(m_Helmet, m_SpawnPosition, Quaternion.identity);
            temp.GetComponent<Helmet>().gameObject.name = m_ID.ToString();
            ++m_ID;
        }

        public void CreateGenericWeapon()
        {
            SetSpawnPosition();
            GameObject temp = Instantiate(m_Weapon, m_SpawnPosition, Quaternion.identity);
            temp.GetComponent<Weapon>().gameObject.name = m_ID.ToString();
            ++m_ID;
        }
    }
}