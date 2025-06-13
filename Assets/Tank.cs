using UnityEngine;

public class Tank : MonoBehaviour
{
    Vector3 velocity;
    Vector3 direction;
    float speed;
    float horizontal = 0;
    float vertical = 0;
    Vector2 maxScreen, minScreen;

    void Start()
    {
        direction = transform.right;
        speed = 1.0f;

        minScreen = Camera.main.ScreenToWorldPoint(Vector2.zero);
        maxScreen = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
    }

    void Update()
    {
        horizontal = -Input.GetAxis("Horizontal") * 0.1f;
        transform.Rotate(0, 0, horizontal);

        vertical = Input.GetAxis("Vertical");
        speed += vertical;

        direction = transform.right;
        velocity = direction *speed * Time.deltaTime;
        transform.position += velocity;
        BoxingTank();
    }

    void BoxingTank()
    {
        Vector3 pos = transform.position;
        if (pos.x > maxScreen.x) { pos.x = minScreen.x; }
        if (pos.x < minScreen.x) { pos.x = maxScreen.x; }
        if (pos.y > maxScreen.y) { pos.y = minScreen.y; }
        if (pos.y < minScreen.y) { pos.y = maxScreen.y; }
        transform.position = pos;
    }
}