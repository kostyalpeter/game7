using UnityEngine;
using UnityEngine.InputSystem;

public class OnClick : MonoBehaviour
{
    float lifetime = 2f;
    void Start()
    {
        Debug.Log("Missed!");
        Destroy(gameObject, lifetime);
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
}
