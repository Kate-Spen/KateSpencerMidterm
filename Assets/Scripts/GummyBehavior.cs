using UnityEngine;

public class GummyBehavior : MonoBehaviour
{
   public Rigidbody2D rb;
   public bool isGrounded = false;
   public int score;
    // Update is called once per frame
    void Update()
    {
        if (!isGrounded){
            rb.linearVelocity = new Vector2(0, rb.linearVelocity.y - 10f* Time.deltaTime);
        }
    }
}
