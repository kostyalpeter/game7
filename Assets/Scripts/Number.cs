using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Number : MonoBehaviour
{
    public int Num1;
    public int Num2;
    public int Num3;
    public int Num4;
    public int Num5;
    public int Num6;
    public int Bet1;
    public int Bet2;
    public int Bet3;
    public int Bet4;
    public int Bet5;
    public int Bet6;
    public Slider Slider1;
    public Slider Slider2;
    public Slider Slider3;
    public Slider Slider4;
    public Slider Slider5;
    public Slider Slider6;
    public TMP_Text Text1;
    public TMP_Text Text2;
    public TMP_Text Text3;
    public TMP_Text Text4;
    public TMP_Text Text5;
    public TMP_Text Text6;
    public int Correct;
    void Start()
    {
        RandomNumber();
    }

    void Update()
    {
        Bet1 = (int)Slider1.value;
        Bet2 = (int)Slider2.value;
        Bet3 = (int)Slider3.value;
        Bet4 = (int)Slider4.value;
        Bet5 = (int)Slider5.value;
        Bet6 = (int)Slider6.value;

        Slider1.minValue = 1;
        Slider1.maxValue = 49;
        Slider2.minValue = 1;
        Slider2.maxValue = 49;
        Slider3.minValue = 1;
        Slider3.maxValue = 49;
        Slider4.minValue = 1;
        Slider4.maxValue = 49;
        Slider5.minValue = 1;
        Slider5.maxValue = 49;
        Slider6.minValue = 1;
        Slider6.maxValue = 49;

        Text1.text = Bet1.ToString();
        Text2.text = Bet2.ToString();
        Text3.text = Bet3.ToString();
        Text4.text = Bet4.ToString();
        Text5.text = Bet5.ToString();
        Text6.text = Bet6.ToString();
    }
    public void RandomNumber()
    {
        Num1 = Random.Range(1, 50);
        Num2 = Random.Range(1, 50);
        Num3 = Random.Range(1, 50);
        Num4 = Random.Range(1, 50);
        Num5 = Random.Range(1, 50);
        Num6 = Random.Range(1, 50);
        Debug.Log(Num1);
        Debug.Log(Num2);
        Debug.Log(Num3);
        Debug.Log(Num4);
        Debug.Log(Num5);
        Debug.Log(Num6);
    }
    public void SendNumbers()
    {
        if (Num1 == Bet1 || Num2 == Bet1 || Num3 == Bet1 || Num4 == Bet1 || Num5 == Bet1 || Num6 == Bet1)
        {
            Correct += 1;
        }
        if (Num1 == Bet2 || Num2 == Bet2 || Num3 == Bet2 || Num4 == Bet2 || Num5 == Bet2 || Num6 == Bet2)
        {
            Correct += 1;
        }
        if (Num1 == Bet3 || Num2 == Bet3 || Num3 == Bet3 || Num4 == Bet3 || Num5 == Bet3 || Num6 == Bet3)
        {
            Correct += 1;
        }
        if (Num1 == Bet4 || Num2 == Bet4 || Num3 == Bet4 || Num4 == Bet4 || Num5 == Bet4 || Num6 == Bet4)
        {
            Correct += 1;
        }
        if (Num1 == Bet5 || Num2 == Bet5 || Num3 == Bet5 || Num4 == Bet5 || Num5 == Bet5 || Num6 == Bet5)
        {
            Correct += 1;
        }
        if (Num1 == Bet6 || Num2 == Bet6 || Num3 == Bet6 || Num4 == Bet6 || Num5 == Bet6 || Num6 == Bet6)
        {
            Correct += 1;
        }
        End();
    }

    void End()
    {
        if (Correct == 1)
        {
            Debug.Log("Win1");
            Correct = 0;
        }
        if (Correct == 2)
        {
            Debug.Log("Win2");
            Correct = 0;
        }
        if (Correct == 3)
        {
            Debug.Log("Win3");
            Correct = 0;
        }
        if (Correct == 4)
        {
            Debug.Log("Win4");
            Correct = 0;
        }
        if (Correct == 5)
        {
            Debug.Log("Win5");
            Correct = 0;
        }
        if (Correct == 6)
        {
            Debug.Log("Win6");
            Correct = 0;
        }
        RandomNumber();
    }

}
