using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.AI;

public class Deneme : MonoBehaviour
{

    [SerializeField] private NavMeshAgent _agent;
    
    [SerializeField] private Graph _graph;
    [SerializeField] private Node fromNode;
    [SerializeField] private Node toNode;
    private bool _isReachedToPoint = true;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Path shortestPath = _graph.GetShortestPath(fromNode, toNode);
        }
        
        ControlReachToPoint();
    }
    
    void ControlReachToPoint()
    {
        if (_isReachedToPoint)
        {
            if (!_agent.pathPending)
            {
                if (_agent.remainingDistance <= _agent.stoppingDistance)
                {
                    if (!_agent.hasPath || _agent.velocity.sqrMagnitude == 0f)
                    {
                        _agent.SetDestination(toNode.transform.position);
                        _isReachedToPoint = true;
                        print("Hedefe ulastik ");
                    }
                }
            }
        }
    }
    
}
