using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBox : MonoBehaviour
{
    enum Tag
    {
        EndPoint
    }

    public bool isOveraped = false;

    private Renderer myRenderer;

    public Color _TouchColor;
    private Color _originalColor;

    // Start is called before the first frame update
    void Start()
    {
        myRenderer = GetComponent<Renderer>();
        _originalColor = myRenderer.material.color;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals(Tag.EndPoint.ToString()))
        {
            isOveraped = true;
            myRenderer.material.color = _TouchColor;
            Debug.Log("���� ����Ʈ�� ����");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag.Equals(Tag.EndPoint.ToString()))
        {
            isOveraped = false;
            myRenderer.material.color = _originalColor;
            Debug.Log("���� ����Ʈ���� Ż��");
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag.Equals(Tag.EndPoint.ToString()))
        {
            isOveraped = true;
            myRenderer.material.color = _TouchColor;
            Debug.Log("���� ����Ʈ�� �ӹ��� ��");
        }
    }
}
