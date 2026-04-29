using UnityEngine;
using UnityEngine.AI;

public class npc : MonoBehaviour
{
    public Transform player;
    public float updateRate = 0.2f;

    private NavMeshAgent agent;
    private float nextUpdateTime;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();

        if (player == null)
        {
            GameObject playerObj = GameObject.FindGameObjectWithTag("Player");
            if (playerObj != null) player = playerObj.transform;
        }
    }

    void Update()
    {
        if (player != null && Time.time >= nextUpdateTime)
        {
            nextUpdateTime = Time.time + updateRate;
            agent.SetDestination(player.position);
        }
    }
}
