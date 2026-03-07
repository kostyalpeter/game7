using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Spin : MonoBehaviour
{
    public Animator animator;
    public int spin;
    public int spinSet;
    public bool canSpin = true;
    public GameObject BG1;
    public GameObject BG2;
    public Slider BetSlider;
    public TMP_Text BetText;
    public int BetAmount;
    public int Money;
    public TMP_Text MoneyText;
    public bool canBet  = true;

    void Start()
    {
        canBet  = true;
    }

    void Update()
    {
        BetSlider.maxValue = Money;
        if (canBet)
        {
            BetAmount = (int)BetSlider.value;
        }
        BetText.text = BetAmount.ToString();
        MoneyText.text = Money.ToString();
    }
    public void Spinning()
    {
        if (canSpin && BetAmount != 0 && spinSet != 0   )
        {
            spin = Random.Range(1, 3);
            Debug.Log(spin);

            if (spin == 1 && canSpin)
            {
                animator.SetTrigger("Spin1");
                Debug.Log("spin1");
            }
            else if (spin == 2 && canSpin)
            {
                animator.SetTrigger("Spin2");
                Debug.Log("spin2");
            }
            StartCoroutine(Wait2());
            StartCoroutine(Wait());
            canBet = false;
        }
    }

    public void Enable()
    {
        canSpin = true;
    }
    public void Disable()
    {
        canSpin = false;
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(6f);
        animator.SetTrigger("SetBack");
        canBet = true;
    }
    IEnumerator Wait2()
    {
        yield return new WaitForSeconds(3.3f);
        if (spinSet == spin)
        {
            Debug.Log("You Won");
            Money += BetAmount * 2;
        }
        else
        {
            Debug.Log("You Lose");
            Money -= BetAmount;
        }
    }

    public void Red()
    {
        spinSet = 1;
        BG1.SetActive(true);
        BG2.SetActive(false);
    }
    public void Black()
    {
        spinSet = 2;
        BG2.SetActive(true);
        BG1.SetActive(false);
    }
}


