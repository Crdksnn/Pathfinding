using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.AI;

public class Deneme : MonoBehaviour
{

    [SerializeField] private NavMeshAgent _agent;
    [SerializeField] private Graph _graph;

    private Path _shortestPath;
    [SerializeField] private Node fromNode;
    private Node _toNode;

    //Nodes
    [SerializeField] private Node nodeA;
    [SerializeField] private Node nodeB;
    [SerializeField] private Node nodeC;
    [SerializeField] private Node nodeD;
    [SerializeField] private Node nodeE;
    [SerializeField] private Node nodeF;
    [SerializeField] private Node nodeG;
    [SerializeField] private Node nodeH;

    private bool _isTargetCity = false;
    void Start()
    {
        
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            _isTargetCity = true;
            _toNode = nodeA;
            _shortestPath = _graph.GetShortestPath(fromNode, _toNode);
            fromNode = nodeA;
            CalculatePathLong(_shortestPath);
        }
        
        else if (Input.GetKeyDown(KeyCode.B))
        {
            _isTargetCity = true;
            _toNode = nodeB;
            _shortestPath = _graph.GetShortestPath(fromNode, _toNode);
            fromNode = nodeB;
            CalculatePathLong(_shortestPath);
        }
        
        else if (Input.GetKeyDown(KeyCode.C))
        {
            _isTargetCity = true;
            _toNode = nodeC;
            _shortestPath = _graph.GetShortestPath(fromNode, _toNode);
            fromNode = nodeC;
            CalculatePathLong(_shortestPath);
        }
        
        else if (Input.GetKeyDown(KeyCode.D))
        {
            _isTargetCity = true;
            _toNode = nodeD;
            _shortestPath = _graph.GetShortestPath(fromNode, _toNode);
            fromNode = nodeD;
            CalculatePathLong(_shortestPath);
        }
        
        else if (Input.GetKeyDown(KeyCode.E))
        {
            _isTargetCity = true;
            _toNode = nodeE;
            _shortestPath = _graph.GetShortestPath(fromNode, _toNode);
            fromNode = nodeE;
            CalculatePathLong(_shortestPath);
        }
        
        else if (Input.GetKeyDown(KeyCode.F))
        {
            _isTargetCity = true;
            _toNode = nodeF;
            _shortestPath = _graph.GetShortestPath(fromNode, _toNode);
            fromNode = nodeF;
            CalculatePathLong(_shortestPath);
        }
        
        else if (Input.GetKeyDown(KeyCode.G))
        {
            _isTargetCity = true;
            _toNode = nodeG;
            _shortestPath = _graph.GetShortestPath(fromNode, _toNode);
            fromNode = nodeG;
            CalculatePathLong(_shortestPath);
        }
        
        else if (Input.GetKeyDown(KeyCode.H))
        {
            _isTargetCity = true;
            _toNode = nodeH;
            _shortestPath = _graph.GetShortestPath(fromNode, _toNode);
            fromNode = nodeH;
            CalculatePathLong(_shortestPath);
        }
            
        MoveToTarget();
    }

    void CalculatePathLong(Path shortestPath)
    {
        
        float distanceBetweenNodes = 0;

        for (int i = 0; i < shortestPath.nodes.Count - 1; i++)
        {
            Node backNode = shortestPath.nodes[i];
            Node nextNode = shortestPath.nodes[i + 1];
            
            distanceBetweenNodes = Vector3.Distance(backNode.transform.position, nextNode.transform.position);
            print("Difference between " + backNode + " " + nextNode + " : " + distanceBetweenNodes);
        }
        
        print(shortestPath.ToString());
    }
    
    void MoveToTarget()
    {
        if (_isTargetCity)
        {
            if (!_agent.pathPending)
            {
                if (_agent.remainingDistance <= _agent.stoppingDistance)
                {
                    if (!_agent.hasPath || _agent.velocity.sqrMagnitude == 0f)
                    {
                        _agent.SetDestination(_toNode.transform.position);
                        _isTargetCity = false;
                    }
                }
            }
        }
    }
    
}
