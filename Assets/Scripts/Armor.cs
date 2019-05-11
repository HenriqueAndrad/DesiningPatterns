using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Factory;

public class Armor : MonoBehaviour, IProduct
{
   [SerializeField] private GameObject m_ArmorPrefab;
    public Vector3 position;
    public Armor(string ID)
    {
        Instantiate(m_ArmorPrefab, position, Quaternion.identity);
        gameObject.name = "A" + ID;
    
    }

    public void SetFirstSprite()
    {
        this.GetComponent<Item>().Image.sprite = this.GetComponent<Item>().Sprites[0];
    }
}
