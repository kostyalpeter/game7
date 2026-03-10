using System.Collections;
using UnityEngine;

public class Game : MonoBehaviour
{
    public GameObject Button;
    public float speed;
    public float minX = -10f;
    public float maxX = 10f;
    public float minY = -10f;
    public float maxY = 10f;
    public GameObject EasyButton;
    public GameObject MediumButton;
    public GameObject HardButton;
    SpriteRenderer spriteRenderer;
    void Start()
    {
        EasyButton.SetActive(true);
        MediumButton.SetActive(true);
        HardButton.SetActive(true);
        spriteRenderer = Button.GetComponent<SpriteRenderer>();
    }
    public void Spawn()
    {
        Vector3 spawnPos = new Vector3(Random.Range(minX, maxX), Random.Range(minY, maxY), 0f);
        GameObject ButtonClone = Instantiate(Button, spawnPos, Quaternion.identity);
        ButtonClone.AddComponent<OnClick>();
        StartCoroutine(Wait());
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(speed);
        Spawn();
    }

    public void Easy()
    {
        speed = 1.5f;
        OnClick.lifetime = 3f;
        EasyButton.SetActive(false);
        MediumButton.SetActive(false);
        HardButton.SetActive(false);
        spriteRenderer.color = Color.green;
    }
    public void Medium()
    {
        speed = 1f;
        OnClick.lifetime = 2f;
        EasyButton.SetActive(false);
        MediumButton.SetActive(false);
        HardButton.SetActive(false);
        spriteRenderer.color = Color.blue;
    }
    public void Hard()
    {
        speed = 0.5f;
        OnClick.lifetime = 1f;
        EasyButton.SetActive(false);
        MediumButton.SetActive(false);
        HardButton.SetActive(false);
        spriteRenderer.color = Color.red;
    }
}