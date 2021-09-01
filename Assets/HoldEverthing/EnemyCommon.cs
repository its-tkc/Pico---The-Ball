using UnityEngine;

public class EnemyCommon : MonoBehaviour
{
    float health = 3f;
   

    private void OnCollisionEnter2D(Collision2D col)
    {
        if(col.relativeVelocity.magnitude > health - 1f)
        {
            ScoreCollector.score += 20;
        }

        if (col.relativeVelocity.magnitude > health)
        {
            Destroy(gameObject);
            ScoreCollector.score += 80;
            InventoryManager.gemContainer += 1;
        }
    }
}
