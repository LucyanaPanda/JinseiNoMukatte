using UnityEngine;

public class EndpointGame : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D coll)
    {
        PlayerManager player = coll.gameObject.GetComponent<PlayerManager>();
        if (player != null)
        {
            player.isFinished = true;
        }
    }
}
