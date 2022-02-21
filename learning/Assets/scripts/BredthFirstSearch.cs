using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BredthFirstSearch : MonoBehaviour
{
    public Node rootNode;
    public Node target;

    private void Start()
    {
        int visitedNodes = BFS(target);
        if (visitedNodes > -1)
        {
            Debug.Log(target.name + " was found by visiting" + visitedNodes + "nodes with BFS");
        }
        else
        {
            Debug.Log(target.name + " was not found.");
        }
    }



    public int BFS(Node target)
    {
        Queue<Node> queue = new Queue<Node>();
        List<Node> visited = new List<Node>();
        queue.Enqueue(rootNode);
        visited.Add(rootNode);

        while (queue.Count > 0)
        {
            Node node = queue.Dequeue();
            Debug.Log("Cheching:" + node.name);
            foreach (Node child in node.children)
            {
                if (visited.Contains(child) == false)
                {
                    Debug.Log("Checking child" + child.name + "of node" + node.name);
                    if (child == target)
                    {
                        Debug.Log("target" + child.name + "of node" + node.name);
                        return visited.Count;
                    }
                    visited.Add(child);
                    queue.Enqueue(child);
                }
            }
        }
        return -1;
    }
}