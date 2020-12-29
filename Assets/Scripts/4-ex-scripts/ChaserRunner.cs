using UnityEngine;
using UnityEngine.AI;


/**
 * This component represents a Chaser Enemy that follows the player
 */
[RequireComponent(typeof(NavMeshAgent))]
public class ChaserRunner: MonoBehaviour {

    [Tooltip("Player position to run after")]
    [SerializeField] private Transform playerPosition = null;

    [Header("For debugging")]
    [SerializeField] private Vector3 currentPlayerPosition;
    [SerializeField] bool hasPath;

    private NavMeshAgent navMeshAgent;
    private Animator animator;
    private float rotationSpeed = 5f;

    private void Start() {
        navMeshAgent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();


        currentPlayerPosition = playerPosition.position;
        SelectNewTarget();
    }

    // go to current player position
    private void SelectNewTarget() {
        navMeshAgent.SetDestination(currentPlayerPosition);
    }


    private void Update() {
        hasPath = navMeshAgent.hasPath;
        if (hasPath) {
            FaceDestination();
        }
        // get player position in runtime
        GameObject playerObj = GameObject.Find("Player");
        currentPlayerPosition = playerObj.transform.position;
        SelectNewTarget();
    }

    private void FaceDestination() {
        Vector3 directionToDestination = (navMeshAgent.destination - transform.position).normalized;
        Quaternion lookRotation = Quaternion.LookRotation(new Vector3(directionToDestination.x, 0, directionToDestination.z));
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * rotationSpeed); // Gradual rotation
    }


}
