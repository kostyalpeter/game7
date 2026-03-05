using System.Collections;
using UnityEngine;

public class Spin : MonoBehaviour
{
    public Animator animator;
    public void Spinning()
    {
        animator.SetTrigger("Spin");
    }
}


