using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class OnClick : MonoBehaviour
{
    public float speed;
    void Start()
    {
        StartCoroutine(Wait());
    }
    void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
            if (hit.collider != null && hit.collider.gameObject == gameObject)
            {
                Debug.Log("Clicked!");
                Destroy(gameObject);
            }
        }
    }
    IEnumerator Wait()
    {
        yield return new WaitForSeconds(speed);
        Debug.Log("Missed!");
        Destroy(gameObject);
    }
}
