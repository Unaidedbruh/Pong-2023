using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wall : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.GetComponent<Ball>())
        {
            float ballHitXDitection = collision.gameObject.GetComponent<Ball>().direction.x;
            float ballHitYDirection = -collision.gameObject.GetComponent<Ball>().direction.y;

            Vector3 hitDirection = new Vector3(ballHitXDitection, ballHitYDirection, 0);
            collision.gameObject.GetComponent<Ball>().Bounce(hitDirection);
        }
    }
}
