using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Info : MonoBehaviour
{
    public GameObject Bubble1;
    public TMP_Text Text1;
    public GameObject Bubble2;
    public TMP_Text Text2;
    public GameObject Bubble3;
    public TMP_Text Text3;

    public void Info1()
    {
        if (Bubble1.activeSelf)
        {
            Bubble1.SetActive(false);
            Text1.gameObject.SetActive(false);
            Bubble2.SetActive(false);
            Text2.gameObject.SetActive(false);
            Bubble3.SetActive(false);
            Text3.gameObject.SetActive(false);
        }
        else
        {
            Bubble1.SetActive(true);
            Text1.gameObject.SetActive(true);
            Bubble2.SetActive(false);
            Text2.gameObject.SetActive(false);
            Bubble3.SetActive(false);
            Text3.gameObject.SetActive(false);
        }
    }
    public void Info2()
    {
        if (Bubble2.activeSelf)
        {
            Bubble2.SetActive(false);
            Text2.gameObject.SetActive(false);
            Bubble1.SetActive(false);
            Text1.gameObject.SetActive(false);
            Bubble3.SetActive(false);
            Text3.gameObject.SetActive(false);
        }
        else
        {
            Bubble2.SetActive(true);
            Text2.gameObject.SetActive(true);
            Bubble1.SetActive(false);
            Text1.gameObject.SetActive(false);
            Bubble3.SetActive(false);
            Text3.gameObject.SetActive(false);
        }
    }
    public void Info3()
    {
        if (Bubble3.activeSelf)
        {
            Bubble3.SetActive(false);
            Text3.gameObject.SetActive(false);
            Bubble2.SetActive(false);
            Text2.gameObject.SetActive(false);
            Bubble1.SetActive(false);
            Text1.gameObject.SetActive(false);
        }
        else
        {
            Bubble3.SetActive(true);
            Text3.gameObject.SetActive(true);
            Bubble2.SetActive(false);
            Text2.gameObject.SetActive(false);
            Bubble1.SetActive(false);
            Text1.gameObject.SetActive(false);
        }
    }

}
