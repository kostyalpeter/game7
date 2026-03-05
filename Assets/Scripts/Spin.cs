using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class Spin : MonoBehaviour
{
    public Animator animator;
    public int spin;
    public int spinSet;
    public bool canSpin = true;
    public GameObject BG1;
    public GameObject BG2;
    public void Spinning()
    {
        if (canSpin)
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
        yield return new WaitForSeconds(4f);
        animator.SetTrigger("SetBack");
    }
    IEnumerator Wait2()
    {
        yield return new WaitForSeconds(3.3f);
        if (spinSet == spin)
        {
            Debug.Log("You Won");
        }
        else
        {
            Debug.Log("You Lose");
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


