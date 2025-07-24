using UnityEngine;

public class Pipe : MonoBehaviour
{
    public float MoveSpeed = 2f;
    public float DestroyX = -10f;
    private bool scored = false;

    private void Update()
    {
        transform.position += Vector3.left * MoveSpeed * Time.deltaTime;

        if (!scored && transform.position.x < 0)
        {
            scored = true;
            GameManager.Instance.IncreaseScore();
        }

        if (transform.position.x < DestroyX)
        {
            Destroy(gameObject);
        }
    }
}
