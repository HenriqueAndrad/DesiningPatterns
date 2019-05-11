using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Command;

public class Item : MonoBehaviour
{
    private string m_Type;
    public string Type
    {
        get { return m_Type; }
        set { m_Type = value; }
    }

    private string m_ID;
    public string ID
    {
        get { return m_ID; }
        set { m_ID = value; }
    }

    [SerializeField] private Sprite[] m_Sprites;
    public Sprite[] Sprites
    {
        get { return m_Sprites; }
    }

    [SerializeField] private Image m_Image;
    public Image Image
    {
        get { return m_Image; }
        set { m_Image = value; }
    }
    [SerializeField] private Text m_Text;

    private void Awake()
    {
        m_Type = "gen";
        m_ID = gameObject.name;
    }

    private void Start()
    {
        m_Text.text = m_ID;
    }

    void Update()
    {
        ChangeSprite();
    }

    public void ChangeSprite()
    {
        if (m_Type == "gen")
        {
            m_Image.sprite = m_Sprites[0];
        }
        else if (m_Type == "/mage")
        {
            m_Image.sprite = m_Sprites[1];
        }
        else if (m_Type == "/warrior")
        {
            m_Image.sprite = m_Sprites[2];
        }
        else if (m_Type == "/thief")
        {
            m_Image.sprite = m_Sprites[3];
        }
    }
}
