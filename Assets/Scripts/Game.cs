using System.Collections;
using UnityEngine;

public class Game : MonoBehaviour
{
    public GameObject Button;
    public float speed;
    public int amount;
    public float minX = -10f;
    public float maxX = 10f;
    public float minY = -10f;
    public float maxY = 10f;
    public void Spawn()
    {
        Vector3 spawnPos = new Vector3(Random.Range(minX, maxX), Random.Range(minY, maxY), 0f);
        GameObject ButtonClone = Instantiate(Button, spawnPos, Quaternion.identity);
        StartCoroutine(Wait());
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(speed);
        Spawn();
    }
}