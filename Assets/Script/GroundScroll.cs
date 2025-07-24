using UnityEngine;

public class GroundScroll : MonoBehaviour
{
    public float ScrollSpeed = 2f;
    public float ResetPositionX; 
    public float StartPositionX; 

    void Update()
    {
        transform.Translate(Vector2.left * ScrollSpeed * Time.deltaTime);

        if (transform.position.x <= ResetPositionX)
        {
            Vector2 newPos = new Vector2(StartPositionX, transform.position.y);
            transform.position = newPos;
        }
    }
}
