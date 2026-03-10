using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class OnClick : MonoBehaviour
{
    public static float lifetime = 2f;
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
                Spin.Money += 1;
            }
        }
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(lifetime);
        Debug.Log("Missed!");
        Destroy(gameObject);
        if (Spin.Money > 0)
        {
            Spin.Money -= 1;
        }
    }
}
