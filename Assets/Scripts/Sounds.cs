using UnityEngine;
using UnityEngine.InputSystem;

public class Sounds : MonoBehaviour
{
    public AudioClip Click;
    public AudioClip SpinSound;
    public AudioSource Src;
    public AudioSource Src2;

    public void Spinning()
    {
        Src.clip = SpinSound;
        Src.loop = true;
        Src.Play();
    }
    public void StopSpinning()
    {
        Src.Stop();
    }
    public void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            Src2.PlayOneShot(Click);
        }
    }
}
