using UnityEngine;
using TMPro;
using System.Collections;
using UnityEngine.UI;

public class TwentyOne : MonoBehaviour
{
    public int Number;
    public TMP_Text Text;
    public int Number2;
    public TMP_Text Text2;
    public Slider Slider1;
    public TMP_Text BetText;
    public float BetAmount;
    [SerializeField] bool canAdd = true;
    [SerializeField] bool canGuess;

    void Start()
    {
        canAdd = true;
        canGuess = false;
    }

    void Update()
    {
        Text.text = Number.ToString();
        Text2.text = Number2.ToString();

        Slider1.maxValue = Spin.Money;
        BetAmount = (float)Slider1.value;
        BetText.text = BetAmount.ToString("0,0");
    }

    public void GiveNumber()
    {
        if (canGuess)
        {
            Number += Random.Range(1, 12);
        }
    }

    public void NumberAdd()
    {
        if (canAdd)
        {
            Number2 = Random.Range(1, 22);
            canAdd = false;
            canGuess = true;
        }
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(2f);
        Number = 0;
        Number2 = 0;
        Spin.Money -= BetAmount;
        canAdd = true;
        canGuess = true;
        Slider1.gameObject.SetActive(true);
    }
    IEnumerator Wait2()
    {
        yield return new WaitForSeconds(2f);
        Number = 0;
        Number2 = 0;
        Spin.Money += BetAmount;
        canAdd = true;
        canGuess = true;
        Slider1.gameObject.SetActive(true);
    }
    public void Stop()
    {
        canGuess = false;

        if (21 - Number >= 21 - Number2 && Number != 0 && Number2 != 0 || Number > 21)
        {
            Debug.Log("Lose");
            StartCoroutine(Wait());
        }

        if (21 - Number < 21 - Number2 && Number != 0 && Number2 != 0)
        {
            Debug.Log("Win");
            StartCoroutine(Wait2());
        }
        Slider1.gameObject.SetActive(false);
    }
}
