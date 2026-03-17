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
        if (Bubble1.gameObject.enabled)
        {
            Bubble1.SetActive(false);
            Text1.gameObject.SetActive(false);
        }
    }

}
