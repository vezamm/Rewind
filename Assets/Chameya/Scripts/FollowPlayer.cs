using UnityEngine;
using UnityEngine.AI;

public class FollowPlayer : MonoBehaviour
{
    [serializefield] private Transform player;
    [serializefield] private float followDistance = 2f;

    private NavMeshAgent agent;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        if (player == null)
        {
            Debug.LogError("Player reference not set on AI Follower!");
        }
    }

    void Update()
    {
        if (player != null)
        {
            float distance = Vector3.Distance(transform.position, player.position);

            if (distance > followDistance)
            {
                agent.SetDestination(player.position);
            }
            else
            {
                agent.ResetPath();
            }
        }
    }
}
