using UnityEngine;
using UnityEngine.AI;


/**
 * This component represents a Brave Enemy that goes to the closest target to the player
 */
[RequireComponent(typeof(NavMeshAgent))]
public class BraveRunner: MonoBehaviour {

    [Tooltip("A game object whose children have a Target component. Each child represents a target.")]
    [SerializeField] private Transform targetFolder = null;

    [Tooltip("Player position to get close to")]
    [SerializeField] private Transform playerPosition = null;

    private Target[] allTargets = null;

    [Header("For debugging")]
    [SerializeField] private Vector3 currentPlayerPosition;

    // keep the closest distance and target
    [SerializeField] private Target closestTarget = null;
    [SerializeField] private float closestDistance = 1000000f;
    // indicates if the enemy has path to go
    [SerializeField] private bool hasPath;


    private NavMeshAgent navMeshAgent;
    private Animator animator;
    private float rotationSpeed = 5f;

    private void Start() {
        // init components
        navMeshAgent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();

        // init targets
        allTargets = targetFolder.GetComponentsInChildren<Target>(false); // get components in active children only
        Debug.Log("Found " + allTargets.Length + " targets.");
        currentPlayerPosition = playerPosition.position;
        SelectNewTarget();
    }

    // select the closest target to player
    private void SelectNewTarget() {
        closestDistance = 1000000;
        foreach(Target target in allTargets)
        {
            float targetDist = Vector3.Distance(target.transform.position,currentPlayerPosition);
            if(targetDist < closestDistance)
            {
                closestDistance = targetDist;
                closestTarget = target;
            }
        }
        navMeshAgent.SetDestination(closestTarget.transform.position);
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
