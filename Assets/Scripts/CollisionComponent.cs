using UnityEngine;

public class CollisionComponent : MonoBehaviour
{
    public PlayerController plr;

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            plr.isGrounded = true;
            plr.animator.SetBool("isGrounded", true);
        }
        else if(collision.gameObject.tag == "Wall" && !plr.isReturn)
        {
            GameManager.Self.SetDamage();
            plr.stats.speed -= plr.stats.speed * 0.05f;
            StartCoroutine(plr.Return());
        }
    }

    /*void OnCollisionExit(Collision collision)
    {
        if(collision.gameObject.layer == 9 && plr.isGrounded && transform.position.y > 0.4f)
        {
            plr.isGrounded = false;
            plr.animator.SetBool("isGrounded", false);
        }
    }*/

    void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.tag == "Dirt")
        {
            plr.isDirt = true;
            plr.stats.speed /= 2;
        }
    }

    void OnTriggerExit(Collider collision)
    {
        if(collision.gameObject.tag == "Dirt")
        {
            plr.stats.speed *= 2;
            plr.isDirt = false;
        }
    }
}
